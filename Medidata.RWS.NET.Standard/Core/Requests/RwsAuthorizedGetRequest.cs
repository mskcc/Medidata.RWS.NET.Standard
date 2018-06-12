using System;
using System.Collections.Generic;
using System.Text;

namespace Medidata.RWS.NET.Standard.Core.Requests
{
    /// <summary>
    /// Represents a GET request that requires authentication.
    /// </summary>
    /// <seealso cref="Medidata.RWS.NET.Standard.Core.Requests.RwsGetRequest" />
    public abstract class RwsAuthorizedGetRequest : RwsGetRequest
    {
        public override bool RequiresAuthentication => true;
    }
}
