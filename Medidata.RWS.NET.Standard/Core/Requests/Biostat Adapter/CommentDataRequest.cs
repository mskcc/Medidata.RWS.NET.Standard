using System;
using Medidata.RWS.NET.Standard.Helpers;
using Flurl;

namespace Medidata.RWS.NET.Standard.Core.Requests.BiostatAdapter
{
    public class CommentDataRequest : RwsAuthorizedGetRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewMetadataRequest"/> class.
        /// </summary>
        /// <param name="datasetFormat">The dataset format.</param>
        public CommentDataRequest(
            string projectName, 
            string environmentName,
            string datasetFormat = "csv")
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

        public string ProjectName { get; }
        public string EnvironmentName { get; }
        public string DatasetFormat { get; }

        public override string UrlPath()
        {
            return Url.Combine("datasets", DataSetName()).SetQueryParam("studyid", StudyNameAndEnvironment());
        }

        /// <summary>
        /// The dataset name.
        /// </summary>
        /// <returns></returns>
        protected virtual string DataSetName()
        {
            return $"SDTMComments{RwsHelpers.DataSets.DatasetFormatToExtension(DatasetFormat)}";
        }


    }
}
