using System;
using System.Net.Http;
using Medidata.RWS.NET.Standard.Core;
using Medidata.RWS.NET.Standard.Core.Responses;

namespace Medidata.RWS.NET.Standard.Exceptions
{
    public class RwsException : Exception
    {

        public RwsException(string message, Exception innerException) : base(message, innerException) { }

        public RwsException(string message, IRwsError response) : base(message)
        {
            ErrorResponse = response;
        }

        public RwsException(string message, HttpResponseMessage responseMessage) : base(message)
        {
            ResponseMessage = responseMessage;
        }

        public IRwsError ErrorResponse { get; }
        public HttpResponseMessage ResponseMessage { get; }
    }
}

