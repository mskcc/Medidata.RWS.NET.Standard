using System.Net.Http;

namespace Medidata.RWS.NET.Standard.Core.Requests
{
    public class RwsTextResponse : IRwsResponse
    {
        public HttpResponseMessage ResponseObject { get; }

        public RwsTextResponse(HttpResponseMessage response)
        {
            ResponseObject = response;
        }



    }
}