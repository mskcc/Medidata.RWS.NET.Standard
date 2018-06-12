using System.Net.Http;

namespace Medidata.RWS.NET.Standard.Core
{
    public interface IRwsResponse
    {
        HttpResponseMessage ResponseObject { get; }

    }
}