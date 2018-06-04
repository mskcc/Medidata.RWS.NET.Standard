using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Medidata.RWS.NET.Standard.Core
{
    public interface IRwsConnection
    {
        string SubDomain { get; }
        string VirtualDirectory { get; }
    
        Task<IRwsResponse> SendRequestAsync(IRwsRequest request, int? timeout = null);
    }
}
