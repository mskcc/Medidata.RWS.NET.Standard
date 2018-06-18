using System.Collections;
using System.Collections.Generic;
using System.Net.Http;

namespace Medidata.RWS.NET.Standard.Core
{
    public interface IRwsRequest
    {
        HttpMethod Method { get; }
        bool RequiresAuthentication { get; }
        HttpContent RequestBody { get; }
        IDictionary<string, string> Headers { get; }

        string UrlPath();
        IRwsResponse Result(HttpResponseMessage response);
    }
}