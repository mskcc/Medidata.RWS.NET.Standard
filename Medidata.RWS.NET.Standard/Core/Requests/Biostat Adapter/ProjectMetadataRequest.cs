using System;
using Medidata.RWS.NET.Standard.Helpers;
using Flurl;

namespace Medidata.RWS.NET.Standard.Core.Requests.BiostatAdapter
{
    public class ProjectMetadataRequest : RwsAuthorizedGetRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectMetadataRequest"/> class.
        /// </summary>
        /// <param name="datasetFormat">The dataset format.</param>
        public ProjectMetadataRequest(string projectName, string datasetFormat = "csv")
        {
            ProjectName = projectName;
            DatasetFormat = datasetFormat;
        }

        public string ProjectName { get; }

        public string DatasetFormat { get; }

        public override string UrlPath()
        {
            return Url.Combine("datasets", DataSetName()).SetQueryParam("ProjectName", ProjectName);
        }

        /// <summary>
        /// The dataset name.
        /// </summary>
        /// <returns></returns>
        protected string DataSetName()
        {
            return $"ClinicalViewMetadata{RwsHelpers.DataSets.DatasetFormatToExtension(DatasetFormat)}";
        }


    }
}
