using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Medidata.RWS.NET.Standard.Core.Responses;

namespace Medidata.RWS.NET.Standard.Core.Requests
{
    public abstract class RwsGetRequest : RwsRequest
    {
        public override HttpMethod Method => HttpMethod.Get;

        public override bool RequiresAuthentication => false;

        public override IRwsResponse Result(HttpResponseMessage response)
        {
            return new RwsResponse(response);
        }
    }
}
