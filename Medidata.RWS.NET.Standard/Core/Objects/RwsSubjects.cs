using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using Medidata.RWS.NET.Standard.Helpers;

namespace Medidata.RWS.NET.Standard.Core.Objects
{
    /// <summary>
    /// Represents a list of subjects.
    /// </summary>
    /// <seealso cref="RwsSubjectListItem" />
    public class RwsSubjects : IEnumerable<RwsSubjectListItem>, IRwsResponse
    {
        readonly List<RwsSubjectListItem> SubjectListItems = new List<RwsSubjectListItem>();

        public HttpResponseMessage ResponseObject { get; }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the collection.
        /// </returns>
        public IEnumerator<RwsSubjectListItem> GetEnumerator()
        {
            return SubjectListItems.GetEnumerator();
        }

        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.
        /// </returns>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        /// <summary>
        /// Gets or sets the <see cref="RwsSubjectListItem"/> at the specified index.
        /// </summary>
        /// <value>
        /// The <see cref="RwsSubjectListItem"/>.
        /// </value>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public RwsSubjectListItem this[int index]
        {
            get { return SubjectListItems[index]; }
            set { SubjectListItems.Insert(index, value); }
        }



        /// <summary>
        /// Initializes a new instance of the <see cref="RwsSubjects"/> class.
        /// </summary>
        /// <param name="xmlString">The XML string.</param>
        public RwsSubjects(string xmlString)
        {
            ODM.ODM odm = RwsHelpers.Xml.DeserializeFromString<ODM.ODM>(xmlString);

            foreach (var clinData in odm.ClinicalData)
            {
                SubjectListItems.Add(new RwsSubjectListItem(clinData));
            }

        }

    }

}
