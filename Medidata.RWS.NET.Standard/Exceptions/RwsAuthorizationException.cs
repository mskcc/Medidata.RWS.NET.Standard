using System;
namespace Medidata.RWS.NET.Standard.Exceptions
{
    public class RwsAuthorizationException : Exception
    {
        public RwsAuthorizationException(string message) : base(message)
        {
        }
    }
}
