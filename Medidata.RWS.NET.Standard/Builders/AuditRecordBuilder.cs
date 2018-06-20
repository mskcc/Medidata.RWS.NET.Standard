using System;
using Medidata.RWS.NET.Standard.ODM;

namespace Medidata.RWS.NET.Standard.Builders
{
    /// <summary>
    /// A builder for constructing "AuditRecord" objects in a state suitable for transmission.
    /// </summary>
    /// <tocexclude />
    public class AuditRecordBuilder : IBuilder<AuditRecord>
    {

        /// <summary>
        /// The AuditRecord object to be built.
        /// </summary>
        private AuditRecord auditRecord;


        /// <summary>
        /// Initializes a new instance of the AuditRecordBuilder class using the specified parameter values.
        /// </summary>
        /// <param name="userOID"></param>
        /// <param name="locationOID"></param>
        /// <param name="reasonForChange"></param>
        /// <param name="sourceID"></param>
        /// <param name="dateTimeStamp"></param>
        public AuditRecordBuilder(string userOID, string locationOID, string reasonForChange, string sourceID, DateTime dateTimeStamp)
        {

            auditRecord = new AuditRecord
            {
                UserRef = new UserRef
                {
                    UserOID = userOID
                },
                DateTimeStamp = new DateTimeStamp
                {
                    Value = dateTimeStamp
                },
                EditPoint = EditPointType.DataManagement,
                LocationRef = new LocationRef { LocationOID = locationOID },
                ReasonForChange = new ReasonForChange { Value = reasonForChange },
                SourceID = new SourceID { Value = sourceID },
                UsedImputationMethod = YesOrNo.No,
                ID = null
            };

        }

        /// <summary>
        /// See <see cref="IBuilder{T}{T}.Build()"></see> for more information.
        /// </summary>
        /// <returns></returns>
        public AuditRecord Build()
        {
            return auditRecord;
        }
    }
}
