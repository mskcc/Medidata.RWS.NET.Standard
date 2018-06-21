using System;
using System.Net.Http;
using Flurl;
using Medidata.RWS.NET.Standard.Core.Objects;

namespace Medidata.RWS.NET.Standard.Core.Requests
{
    public class MetadataStudiesRequest : RwsAuthorizedGetRequest
    {
        public override string UrlPath()
        {
            return Url.Combine("metadata", "studies");
        }

        public override IRwsResponse Result(HttpResponseMessage response)
        {
            return new RwsStudies(response.Content.ReadAsStringAsync().Result);
        }
    }
}
