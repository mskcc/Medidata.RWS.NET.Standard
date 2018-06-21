using System;
using Flurl;
using Medidata.RWS.NET.Standard.Helpers;

namespace Medidata.RWS.NET.Standard.Core.Requests.BiostatAdapter
{
    /// <summary>
    /// Retrieve data dictionaries from RAVE.
    /// </summary>
    public class DataDictionariesRequest : FormattedDataSetRequest
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataDictionariesRequest"/> class.
        /// </summary>
        /// <param name="projectName">Name of the project.</param>
        /// <param name="environmentName">Name of the environment.</param>
        /// <param name="datasetFormat">The dataset format.</param>
        public DataDictionariesRequest(string projectName, string environmentName, string datasetFormat = "csv") : base(projectName, environmentName, datasetFormat)
        {
        }


        public override string UrlPath()
        {

            return Url.Combine("datasets", $"{DataSetName()}?studyid={StudyNameAndEnvironment()}");
                      
        }



        /// <summary>
        /// The dataset name.
        /// </summary>
        /// <returns></returns>
        protected override string DataSetName()
        {
            return $"SDTMDataDictionaries{RwsHelpers.DataSets.DatasetFormatToExtension(DatasetFormat)}";
        }
    }
}
