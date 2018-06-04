using System;
using System.Collections.Generic;
using System.Text;
using Flurl;

namespace Medidata.RWS.NET.Standard.Core.Requests
{
    public class VersionRequest : RwsGetRequest
    {
        public override string UrlPath()
        {
            return Url.Combine("version");
        }
    }
}
