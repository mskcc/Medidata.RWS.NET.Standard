using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Medidata.RWS.NET.Standard.Core.Responses
{
    class RwsResponse : IRwsResponse
    {
        private readonly HttpResponseMessage _response;

        public RwsResponse(HttpResponseMessage response)
        {
            _response = response;
        }

        public HttpResponseMessage Response => _response;
    }
}
