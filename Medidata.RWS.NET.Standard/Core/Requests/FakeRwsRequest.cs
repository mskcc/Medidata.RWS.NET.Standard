using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Medidata.RWS.NET.Standard.Core.Requests
{
    public class FakeRwsRequest : IRwsRequest
    {
        public HttpMethod Method { get; set; }
        public bool RequiresAuthentication { get; set; }
        public HttpContent RequestBody { get; set; }
        public IEnumerable Headers { get; set; }

        public string UrlPath()
        {
            return "fakepath";
        }


        public FakeRwsRequest(HttpMethod method)
        {
            Method = method;
        }

}
}
