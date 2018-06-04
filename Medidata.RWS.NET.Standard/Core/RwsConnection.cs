using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Medidata.RWS.NET.Standard.Core.Responses;

namespace Medidata.RWS.NET.Standard.Core
{
    public class RwsConnection : IRwsConnection
    {
        private readonly string _username;
        private readonly string _password;
        private readonly string _subDomain;
        private readonly string _virtualDir;
        protected readonly string BaseUrl;

        public string SubDomain => _subDomain;
        public string VirtualDirectory => _virtualDir;


        public RwsConnection(string subDomain, string virtualDir = "RaveWebServices")
        {
            this._subDomain = subDomain;
            this._virtualDir = virtualDir;

            BaseUrl = Url.Combine(
                subDomain.ToLower().StartsWith("http") ? subDomain : $"https://{subDomain}.mdsol.com",
                virtualDir
            );
                   
            ServicePointManager.SecurityProtocol = ServicePointManager.SecurityProtocol | SecurityProtocolType.Tls12;

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RwsConnection"/> class.
        /// </summary>
        /// <param name="domain">The client portion of the Medidata RWS url, e.g. `mediflex`.</param>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <param name="virtual_dir">The virtual directory.</param>
        public RwsConnection(string subDomain, string username, string password, string virtualDir = "RaveWebServices") : this(subDomain, virtualDir)
        {
            _username = username;
            _password = password;
        }


        public async System.Threading.Tasks.Task<IRwsResponse> SendRequestAsync(IRwsRequest request, int? timeout = null)
        {
            var client = new FlurlRequest(BaseUrl);

            if (timeout != null)
            {
                client.WithTimeout((int) timeout);
            }

            if (request.RequiresAuthentication)
            {
                client.WithBasicAuth(_username, _password);
            }

            client.WithHeaders(request.Headers);

            var response = await BaseUrl
                .SendAsync(request.Method, request.RequestBody);

            LastResult = response;

            return new RwsResponse(response);

        }

        public HttpResponseMessage LastResult { get; set; }
    }
}
