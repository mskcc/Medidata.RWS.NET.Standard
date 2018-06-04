using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Medidata.RWS.NET.Standard.Core
{
    public interface IRwsConnection
    {
        string SubDomain { get; }

        string VirtualDirectory { get; }

        TimeSpan RequestTime { get; }

        HttpResponseMessage LastResult { get;  }

        Task<IRwsResponse> SendRequestAsync(IRwsRequest request, int? timeout = null);

    }
}
