using System;
using System.Collections.Generic;
using System.Text;

namespace Medidata.RWS.NET.Standard.Core.Requests
{
    /// <summary>
    /// Represents a POST request that requires authentication.
    /// </summary>
    /// <seealso cref="Medidata.RWS.NET.Standard.Core.Requests.RwsPostRequest" />
    public abstract class RwsAuthorizedPostRequest : RwsPostRequest
    {
        public override bool RequiresAuthentication => true;
    }
}
