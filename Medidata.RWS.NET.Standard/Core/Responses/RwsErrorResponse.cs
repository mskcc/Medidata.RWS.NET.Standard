using System;
using System.Net.Http;
using Medidata.RWS.NET.Standard.Core.Responses;

namespace Medidata.RWS.NET.Standard.Core.Responses
{
    public class RwsErrorResponse : RwsXmlResponse, IRwsError
    {
        private string errorDescription;

        public RwsErrorResponse(HttpResponseMessage responseMessage) : base(responseMessage)
        {
            ReasonCode = RootElement?.Attribute("ReasonCode")?.Value;

            SetErrorDescription(RootElement?.Attribute("ErrorClientResponseMessage")?.Value); 

        }

        protected void SetErrorDescription(string value)
        {
            errorDescription = value;
        }

        public readonly string ReasonCode; 

        public string GetErrorDescription()
        {
            return errorDescription;
        }
    }
}
