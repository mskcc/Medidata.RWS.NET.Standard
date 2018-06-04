using System.Collections;
using System.Net.Http;

namespace Medidata.RWS.NET.Standard.Core
{
    public interface IRwsRequest
    {
        HttpMethod Method { get; set; }
        bool RequiresAuthentication { get; set; }
        HttpContent RequestBody { get; set; }
        IEnumerable Headers { get; set; }
        string UrlPath();
    }
}