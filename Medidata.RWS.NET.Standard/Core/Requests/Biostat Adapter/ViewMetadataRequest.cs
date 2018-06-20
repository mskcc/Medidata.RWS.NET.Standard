using System;
using Medidata.RWS.NET.Standard.Helpers;
using Flurl;

namespace Medidata.RWS.NET.Standard.Core.Requests.BiostatAdapter
{
    public class ViewMetadataRequest : RwsAuthorizedGetRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewMetadataRequest"/> class.
        /// </summary>
        /// <param name="datasetFormat">The dataset format.</param>
        public ViewMetadataRequest(string viewName, string datasetFormat = "csv")
        {
            ViewName = viewName;
            DatasetFormat = datasetFormat;
        }

        public string ViewName { get; }
        public string DatasetFormat { get; }

        public override string UrlPath()
        {
            return Url.Combine("datasets", DataSetName()).SetQueryParam("ViewName", ViewName);
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
