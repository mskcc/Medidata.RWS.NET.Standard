using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Flurl;
using Medidata.RWS.NET.Standard.Core.Objects;

namespace Medidata.RWS.NET.Standard.Core.Requests
{
    public class StudyVersionsRequest : RwsAuthorizedGetRequest
    {
        private readonly string _projectName;

        public StudyVersionsRequest(string projectName)
        {
            _projectName = projectName;
        }

        public override string UrlPath()
        {
            return Url.Combine("metadata", "studies", _projectName, "versions");
        }

        public override IRwsResponse Result(HttpResponseMessage response)
        {
            return new RwsStudyMetadataVersions(response.Content.ReadAsStringAsync().Result);
        }
    }
}
