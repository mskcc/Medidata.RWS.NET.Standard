using System;
using System.Net.Http;
using Medidata.RWS.NET.Standard.Core.Responses;

namespace Medidata.RWS.NET.Standard.ODM
{
    public partial class ODM : RwsXmlResponse
    {
        public ODM(HttpResponseMessage responseMessage) : base(responseMessage)
        {
            
        }

        public ODM() : base()
        {
            
        }
  
    }
}
