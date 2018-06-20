using System;
using System.Collections.Generic;
using System.Net.Http;
using Medidata.RWS.NET.Standard.Core.Responses;

namespace Medidata.RWS.NET.Standard.Core.Requests.BiostatAdapter
{
    /// <summary>
    /// Return data from rave as CSV or XML. 
    /// </summary>
    public abstract class FormattedDataSetRequest : RwsAuthorizedGetRequest
    {
        /// <summary>
        /// The allowed dataset formats
        /// </summary>
        public readonly Dictionary<string, string> DatasetFormats = new Dictionary<string, string>
        {
            { "csv", ".csv"  },
            { "xml", ""  },
        };

        protected readonly string ProjectName;
        protected readonly string EnvironmentName;
        protected readonly string DatasetFormat;

        /// <summary>
        /// Initializes a new instance of the <see cref="FormattedDataSetRequest" /> class.
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        /// <param name="environmentName">Name of the environment.</param>
        /// <param name="datasetFormat">The dataset format.</param>
        protected FormattedDataSetRequest(string projectName, string environmentName, string datasetFormat = "csv")
        {
            ProjectName = projectName;
            EnvironmentName = environmentName;
            DatasetFormat = datasetFormat;
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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected abstract string DataSetName();


        /// <summary>
        /// Gets the format extension.
        /// </summary>
        /// <param name="format">The format.</param>
        /// <returns></returns>
        /// <exception cref="System.NotSupportedException"></exception>
        public string GetFormatExtension(string format)
        {
            try
            {
                return DatasetFormats[format.ToLower()];
            }
            catch (Exception)
            {
                throw new NotSupportedException(
                    $"datasetFormat must be one of the following: {string.Join(",", DatasetFormats.Keys)}. `{format}` is not valid.");
            }
        }


        /// <summary>
        /// Return the XML or CSV representation of the response, based on the DataSetFormat.
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        public override IRwsResponse Result(HttpResponseMessage response)
        {
            if (DatasetFormat.ToLower() == "xml")
            {
                return new RwsResponse(response);
            }
            return new RwsTextResponse(response);
        }

    }
}
