using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Medidata.RWS.NET.Standard.Core.Requests
{
    public abstract class RwsRequest : IRwsRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RWSRequest"/> class.
        /// </summary>
        protected RwsRequest()
        {
            Headers = new Dictionary<string, string>();
        }

        /// <summary>
        /// Gets the HTTP method of the request
        /// </summary>
        /// <value>
        /// The method.
        /// </value>
        public abstract HttpMethod Method { get; }

        /// <summary>
        /// Gets or sets a value indicating whether [requires authentication].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [requires authentication]; otherwise, <c>false</c>.
        /// </value>
        public abstract bool RequiresAuthentication { get; }

        /// <summary>
        /// Gets or sets the request body.
        /// </summary>
        /// <value>
        /// The request body.
        /// </value>
        public HttpContent RequestBody { get; protected set; }

        /// <summary>
        /// Gets or sets the headers.
        /// </summary>
        /// <value>s
        /// The headers.
        /// </value>
        public IDictionary<string, string> Headers { get; protected set; }
        
        /// <summary>
        /// The URL path for the request.
        /// </summary>
        /// <returns></returns>
        public abstract string UrlPath();

        /// <summary>
        /// Gets the result of the request after it has been executed.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <returns></returns>
        public abstract IRwsResponse Result(HttpResponseMessage response);
    }
}
