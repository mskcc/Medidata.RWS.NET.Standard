using System;
using Medidata.RWS.NET.Standard.Helpers;
using Flurl;

namespace Medidata.RWS.NET.Standard.Core.Requests.BiostatAdapter
{
    public class MetadataRequest : RwsAuthorizedGetRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataRequest"/> class.
        /// </summary>
        /// <param name="datasetFormat">The dataset format.</param>
        public MetadataRequest(string datasetFormat = "csv")
        {
            DatasetFormat = datasetFormat;
        }

        public string DatasetFormat { get; }

        public override string UrlPath()
        {
            return Url.Combine("datasets", DataSetName());
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
