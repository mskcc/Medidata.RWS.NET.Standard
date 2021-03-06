﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Medidata.RWS.NET.Standard.Core.Responses;

namespace Medidata.RWS.NET.Standard.Core.Requests
{
    public class FakeRwsRequest : RwsRequest
    {
        public override HttpMethod Method => HttpMethod.Get;

        public override bool RequiresAuthentication => false;

        public override string UrlPath()
        {
            return "fakepath";
        }

        public override IRwsResponse Result(HttpResponseMessage response)
        {
           return new RwsResponse(response);
        }
    }
}
