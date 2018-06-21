using System;
using System.Collections.Generic;
using Flurl;

namespace Medidata.RWS.NET.Standard.Core.Requests.ODMAdapter
{
    /// <summary>
    /// Users admin data can be retrieved for each site using the Users pre-installed custom dataset.
    /// </summary>
    public class UsersRequest : QueryOptionGetRequest
    {
        private readonly string Environment;
        private readonly string ProjectName;


        /// <summary>
        /// The site number, example: "1234567".  Optional.
        /// </summary>
        public string locationoid { get; private set; }

        /// <summary>
        /// The study name and environment, for example: "Mediflex(Prod)"
        /// </summary>
        public string studyoid => string.IsNullOrWhiteSpace(Environment) ? $"{ProjectName}" : $"{ProjectName}({Environment})";


        /// <summary>
        /// Initializes a new instance of the <see cref="UsersRequest"/> class.
        /// </summary>
        /// <param name="ProjectName">Name of the project.</param>
        /// <param name="Environment">The environment.</param>
        /// <param name="locationoid">The locationoid.</param>
        public UsersRequest(string ProjectName, string Environment, string locationoid = default(string))
        {
            this.ProjectName = ProjectName;
            this.Environment = Environment;
            this.locationoid = locationoid;
        }

        /// <summary>
        /// The list of query string parameters that can be supplied for this request.
        /// </summary>
        public override List<string> KnownQueryOptions
        {
            get
            {
                return new List<string> { "studyoid", "locationoid" };
            }
        }

        /// <summary>
        /// The request URL path.
        /// </summary>
        /// <returns></returns>
        public override string UrlPath()
        {

            return Url.Combine("datasets", "Users.odm").SetQueryParams(QueryString());

        }
    }
}
