using System;
using System.Collections.Generic;
using Medidata.RWS.NET.Standard.ODM;

namespace Medidata.RWS.NET.Standard.Builders
{
    /// <summary>
    /// A builder for constructing "ClinicalData" objects in a state suitable for transmission.
    /// </summary>
    /// <tocexclude />
    public class ClinicalDataBuilder : IBuilder<List<ClinicalData>>
    {

        /// <summary>
        /// The object context to be constructed
        /// </summary>
        private List<ClinicalData> clinicalDataList;

        /// <summary>
        /// Represents the first node of the clinicalDataList list.
        /// </summary>
        private ClinicalData clinicalData;

        /// <summary>
        /// Initializes a new instance of the ClinicalDataBuilder class using the specified StudyOID value.
        /// </summary>
        /// <param name="StudyOID"></param>
        public ClinicalDataBuilder(string StudyOID)
        {

            clinicalData = new ClinicalData
            {
                MetaDataVersionOID = "1",
                StudyOID = StudyOID,
                SubjectData = new List<SubjectData>()
            };

            clinicalDataList = new List<ClinicalData>
            {
                clinicalData
            };

        }

        /// <summary>
        /// Add a "SubjectKey" node using the specified parameter values.
        /// </summary>
        /// <param name="SubjectKey"></param>
        /// <param name="LocationOID"></param>
        /// <param name="subjectDataBuilder"></param>
        /// <returns></returns>
        public ClinicalDataBuilder WithSubjectData(string SubjectKey, string LocationOID, Action<SubjectDataBuilder> subjectDataBuilder)
        {
            var sdb = new SubjectDataBuilder(SubjectKey, LocationOID);
            subjectDataBuilder(sdb);
            clinicalData.SubjectData.Add(sdb.Build());
            return this;
        }


        /// <summary>
        /// See <see cref="IBuilder{T}.Build()"/> for more information. 
        /// </summary>
        /// <returns></returns>
        public List<ClinicalData> Build()
        {
            return clinicalDataList;
        }



    }
}