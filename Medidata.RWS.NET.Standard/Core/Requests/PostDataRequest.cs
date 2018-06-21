using System;
using System.Net.Http;
using Flurl;
using Medidata.RWS.NET.Standard.Core.Responses;

namespace Medidata.RWS.NET.Standard.Core.Requests
{
    public class PostDataRequest : RwsAuthorizedPostRequest
    { 

        protected string DataString { get; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostDataRequest"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public PostDataRequest(string data)
        {
            DataString = data;
            RequestBody = new StringContent(data);
            Headers.Add("Content-type", "text/xml");
        }

        public override string UrlPath()
        {
            return Url.Combine("webservice.aspx?PostODMClinicalData");
        }

        public override IRwsResponse Result(HttpResponseMessage response)
        {
            return new RwsPostResponse(response);
        }
    }
}
