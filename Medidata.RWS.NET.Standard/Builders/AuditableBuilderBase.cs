using System;
using Medidata.RWS.NET.Standard.ODM;

namespace Medidata.RWS.NET.Standard.Builders
{
    /// <summary>
    /// Provides a base class for ODM data builders that need to attach an AuditRecord object to their output. This class cannot be instantiated. 
    /// </summary>
    /// <typeparam name="DataClass"></typeparam>
    /// <typeparam name="BuilderClass"></typeparam>
    /// <tocexclude />
    public abstract class AuditableBuilderBase<DataClass, BuilderClass> : IAuditableBuilder<DataClass, BuilderClass>
    {

        /// <summary>
        /// The object context to be constructed.
        /// </summary>
        protected DataClass thisNode;

        /// <summary>
        /// Fluent method for attaching an Audit Record to this instance.
        /// </summary>
        /// <param name="record">The record.</param>
        /// <returns>
        /// The BuilderClass.
        /// </returns>
        public BuilderClass WithAuditRecord(AuditRecord record)
        {
            dynamic d =  thisNode;
            d.AuditRecord = record;
            return ThisAsTSelf();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <tocexclude />
        protected abstract BuilderClass ThisAsTSelf();

        /// <summary>
        /// See <see cref="IBuilder{T}.Build()"></see> for more information.
        /// </summary>
        /// <returns></returns>
        /// <tocexclude />
        public DataClass Build()
        {
            return thisNode;
        }

        /// <summary>
        /// See <see cref="IAuditableBuilder{DataClass, BuilderClass}.WithAuditRecord(string, string, string, string, DateTime, Action{AuditRecordBuilder})"/> for more information. 
        /// </summary>
        /// <param name="UserOID"></param>
        /// <param name="LocationOID"></param>
        /// <param name="ReasonForChange"></param>
        /// <param name="SourceID"></param>
        /// <param name="DateTimeStamp"></param>
        /// <param name="auditRecordBuilder"></param>
        /// <returns></returns>
        /// <tocexclude />
        public BuilderClass WithAuditRecord(string UserOID, string LocationOID, string ReasonForChange, string SourceID, DateTime DateTimeStamp, Action<AuditRecordBuilder> auditRecordBuilder)
        {
            var arb = new AuditRecordBuilder(UserOID, LocationOID, ReasonForChange, SourceID, DateTimeStamp);

            auditRecordBuilder(arb);

            dynamic d = thisNode;

            d.AuditRecord = arb.Build();

            return ThisAsTSelf();
        }
    }
}
