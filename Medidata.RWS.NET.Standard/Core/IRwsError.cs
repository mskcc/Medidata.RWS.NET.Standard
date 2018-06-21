using System;
namespace Medidata.RWS.NET.Standard.Core
{
    public interface IRwsError : IRwsResponse
    {
        string GetErrorDescription();
    }
}
