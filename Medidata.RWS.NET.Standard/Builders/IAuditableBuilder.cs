using System;

namespace Medidata.RWS.NET.Standard.Builders
{
    
	/// <summary>
    /// An extended version of <see cref="IBuilder{T}"/> that provides the ability to attach AuditRecord nodes to the object context.
    /// </summary>
    /// <typeparam name="DataClass"></typeparam>
    /// <typeparam name="BuilderClass"></typeparam>
    /// <tocexclude />
    public interface IAuditableBuilder<DataClass, BuilderClass> : IBuilder<DataClass>
    {
        /// <summary>
        /// Add an AuditRecord object to the current object context using the specified parameter values.  Returns the specified Builder class. 
        /// </summary>
        /// <param name="UserOID"></param>
        /// <param name="LocationOID"></param>
        /// <param name="ReasonForChange"></param>
        /// <param name="SourceID"></param>
        /// <param name="DateTimeStamp"></param>
        /// <param name="auditRecordBuilder"></param>
        /// <returns></returns>
        BuilderClass WithAuditRecord(string UserOID, string LocationOID, string ReasonForChange, string SourceID, DateTime DateTimeStamp, Action<AuditRecordBuilder> auditRecordBuilder);
    }
}
