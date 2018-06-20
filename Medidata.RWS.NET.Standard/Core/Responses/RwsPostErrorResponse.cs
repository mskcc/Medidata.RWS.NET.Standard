using System;
using System.Net.Http;
using Medidata.RWS.NET.Standard.Core.Responses;

namespace Medidata.RWS.NET.Standard.Core.Responses
{
    public class RwsPostErrorResponse : RwsResponse, IRwsError
    {
        private string errorDescription;

        public RwsPostErrorResponse(HttpResponseMessage responseMessage) : base(responseMessage)
        {
            ReasonCode = RootElement?.Attribute("ReasonCode")?.Value;

            SetErrorDescription(RootElement?.Attribute("ErrorClientResponseMessage")?.Value); 

            ErrorOriginLocation = RootElement?.Attribute("ErrorOriginLocation")?.Value;

        }

        protected void SetErrorDescription(string value)
        {
            errorDescription = value;
        }

        public readonly string ReasonCode;

        public string ErrorOriginLocation { get;  protected set; }

        public string GetErrorDescription()
        {
            return errorDescription;
        }
    }
}
