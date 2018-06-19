using System.Net.Http;
using Flurl;
using Medidata.RWS.NET.Standard.Core.Objects;

namespace Medidata.RWS.NET.Standard.Core.Requests
{
    public class ClinicalStudiesRequest : RwsAuthorizedGetRequest
    {
        public override string UrlPath()
        {
            return Url.Combine("studies");
        }

        public override IRwsResponse Result(HttpResponseMessage response)
        {
            return new RwsStudies(response.Content.ReadAsStringAsync().Result);
        }
    }
}