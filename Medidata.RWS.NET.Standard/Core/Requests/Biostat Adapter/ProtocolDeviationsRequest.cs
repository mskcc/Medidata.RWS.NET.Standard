using System;
using Flurl;
using Medidata.RWS.NET.Standard.Helpers;

namespace Medidata.RWS.NET.Standard.Core.Requests.BiostatAdapter
{
	public class ProtocolDeviationsRequest : CommentDataRequest
    {
        public ProtocolDeviationsRequest(string projectName, string environmentName, string datasetFormat = "csv") : base(projectName, environmentName, datasetFormat)
        {
        }

        /// <summary>
        /// The dataset name.
        /// </summary>
        /// <returns></returns>
        protected override string DataSetName()
        {
            return $"SDTMProtocolDeviations{RwsHelpers.DataSets.DatasetFormatToExtension(DatasetFormat)}";
        }
    }
}
