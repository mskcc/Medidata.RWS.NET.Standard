using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Flurl;
using Medidata.RWS.NET.Standard.Core.Responses;

namespace Medidata.RWS.NET.Standard.Core.Requests
{
    public class VersionRequest : RwsGetRequest
    {
        public override string UrlPath()
        {
            return Url.Combine("version");
        }

        public override IRwsResponse Result(HttpResponseMessage response)
        {
            return new RwsTextResponse(response);
        }
    }
}
