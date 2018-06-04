using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Medidata.RWS.NET.Standard.Core.Responses
{
    class RwsResponse : IRwsResponse
    {
        public RwsResponse(HttpResponseMessage response)
        {
            Response = response;
        }

        public HttpResponseMessage Response { get; }
    }
}
