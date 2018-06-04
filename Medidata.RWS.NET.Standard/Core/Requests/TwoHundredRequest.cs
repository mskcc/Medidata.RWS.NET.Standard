using System;
using System.Collections.Generic;
using System.Text;
using Flurl;

namespace Medidata.RWS.NET.Standard.Core.Requests
{
    public class TwoHundredRequest : RwsGetRequest
    {
        public override string UrlPath()
        {
            return Url.Combine("twohundred");
        }
    }
}
