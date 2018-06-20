using System;
using Medidata.RWS.NET.Standard.ODM;

namespace Medidata.RWS.NET.Standard.Builders
{
  
	/// <summary>
    /// Indicates that the implementation can set a TransactionType parameter.
    /// </summary>
    /// <typeparam name="BuilderClass"></typeparam>
    /// <tocexclude />
    public interface SpecifiesTransactionType<BuilderClass>
    {
        /// <summary>
        /// Set the transaction type on the object being built.
        /// </summary>
        /// <param name="tranxType"></param>
        /// <returns></returns>
        BuilderClass WithTransactionType(TransactionType tranxType);

    }
}
