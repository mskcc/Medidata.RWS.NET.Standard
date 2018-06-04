using System.Collections;
using System.Net.Http;

namespace Medidata.RWS.NET.Standard.Core
{
    public interface IRwsRequest
    {
        HttpMethod Method { get; }
        bool RequiresAuthentication { get; }
        HttpContent RequestBody { get; }
        IEnumerable Headers { get; }
        string UrlPath();
        IRwsResponse Result(HttpResponseMessage response);
    }
}