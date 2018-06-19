using System;
using System.Net.Http;
using System.Xml.Serialization;
using Medidata.RWS.NET.Standard.ODM;

namespace Medidata.RWS.NET.Standard.Core.Objects
{
	public class RwsError : ODM.ODM, IRwsError
    {
        private string errorDescription;

        public string GetErrorDescription()
        {
            return errorDescription;
        }

        protected void SetErrorDescription(string value)
        {
            errorDescription = value;
        }

        public RwsError(HttpResponseMessage responseMessage): base(responseMessage)
        {
            SetErrorDescription(RootElement?.Attribute("ErrorDescription")?.Value); 
        }


    }
}
