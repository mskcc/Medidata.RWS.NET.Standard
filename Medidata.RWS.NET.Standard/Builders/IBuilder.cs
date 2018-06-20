using System;
namespace Medidata.RWS.NET.Standard.Builders
{
    /// <summary>
    /// Basic Builder interface.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <tocexclude />
    public interface IBuilder<T>
    {
        /// <summary>
        /// Builds the object context.
        /// </summary>
        /// <returns></returns>
        T Build();
    }
}
