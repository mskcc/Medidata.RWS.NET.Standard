﻿using System;
using System.Collections.Generic;
using Flurl;
using Medidata.RWS.NET.Standard.Helpers;

namespace Medidata.RWS.NET.Standard.Core.Requests.BiostatAdapter
{
    /// <summary>
    /// Return Clinical View form data as CSV or XML
    /// </summary>
    public class FormDataRequest : QueryOptionGetRequest
    {

        /// <summary>
        /// The allowed dataset formats
        /// </summary>
        public readonly Dictionary<string, string> DatasetFormats = new Dictionary<string, string>
        {
            { "csv", ".csv"  },
            { "xml", ""  },
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="FormDataRequest"/> class.
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        /// <param name="environmentName">Name of the environment.</param>
        /// <param name="datasetFormat">The dataset format.</param>
        public FormDataRequest(
            string projectName, 
            string environmentName, 
            string datasetFormat = "csv",
            string formOid = default(string),
            string start = default(string)
        )
        {
            ProjectName = projectName;
            EnvironmentName = environmentName;
            DatasetFormat = datasetFormat;
            FormOid = formOid;
            Start = start;
        }

        public override List<string> KnownQueryOptions => throw new NotImplementedException();

        public string ProjectName { get; }
        public string EnvironmentName { get; }
        public string DatasetFormat { get; }
        public string FormOid { get; }
        public string Start { get; }

        public override string UrlPath()
        {
            return Url.Combine("studies", StudyNameAndEnvironment(), "datasets", DataSetName());
        }

   

        /// <summary>
        /// The dataset name.
        /// </summary>
        /// <returns></returns>
        protected string DataSetName()
        {
            return $"{FormOid}{RwsHelpers.DataSets.DatasetFormatToExtension(DatasetFormat)}";
        }


        /// <summary>
        /// Get the Study and Environment names in a format RWS expects.
        /// If no environment name is provided, it is left out of the return string.
        /// </summary>
        /// <returns></returns>
        protected string StudyNameAndEnvironment()
        {
            return string.IsNullOrWhiteSpace(EnvironmentName) ? $"{ProjectName}" : $"{ProjectName}({EnvironmentName})";
        }
    }
}
