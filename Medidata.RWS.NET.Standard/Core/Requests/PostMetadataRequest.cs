using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Flurl;
using Medidata.RWS.NET.Standard.Core.Responses;

namespace Medidata.RWS.NET.Standard.Core.Requests
{
    public class PostMetadataRequest : RwsAuthorizedPostRequest
    {
        public string ProjectName { get; }
        protected string DataString { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PostMetadataRequest"/> class.
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        /// <param name="data">The data.</param>
        public PostMetadataRequest(string projectName, string data)
        {
            ProjectName = projectName;
            DataString = data;
            RequestBody = new StringContent(data);
            Headers.Add("Content-type", "text/xml");
        }

        public override string UrlPath()
        {
            return Url.Combine("metadata", "studies", ProjectName, "drafts");
        }

        public override IRwsResponse Result(HttpResponseMessage response)
        {
            return new RwsPostResponse(response);
        }

    }
}
