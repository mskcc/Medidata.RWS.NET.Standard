using System;
using System.Linq;
using Medidata.RWS.NET.Standard.ODM;

namespace Medidata.RWS.NET.Standard.Core.Objects
{
    /// <summary>
    /// Represents a single subject
    /// </summary>
    public class RwsSubjectListItem
    {
        /// <summary>
        /// The metadata version oid
        /// </summary>
        public readonly string MetadataVersionOid;
        /// <summary>
        /// The study oid
        /// </summary>
        public readonly string StudyOid;
        /// <summary>
        /// The subject key
        /// </summary>
        public readonly string SubjectKey;

        public readonly string LocationOid;

        public readonly SiteRef SiteRef;

        public readonly SubjectData SubjectData;

        /// <summary>
        /// Initializes a new instance of the <see cref="RwsSubjectListItem"/> class.
        /// </summary>
        /// <param name="clinData">The clinical data.</param>
        public RwsSubjectListItem(ClinicalData clinData)
        {
            StudyOid = clinData.StudyOID;
            MetadataVersionOid = clinData.MetaDataVersionOID;
            SubjectData = clinData.SubjectData.First();
            SubjectKey = SubjectData.SubjectKey;
            SiteRef = SubjectData.SiteRef;
            LocationOid = SiteRef.LocationOID;
        }

        /// <summary>
        /// Get the subject name - if the SubjectKeyType is SubjectUUID
        /// then the subject name lives in the mdsol:SubjectName attribute. Otherwise, just return SubjectKey.
        /// </summary>
        public string SubjectName
        {
            get
            {
                if (SubjectData.SubjectKeyType != null && SubjectData.SubjectKeyType.ToLower() == "SubjectUUID".ToLower())
                {
                    return SubjectData.SubjectName;
                }

                return SubjectKey;

            }
        }

    }
}
