using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using Medidata.RWS.NET.Standard.Helpers;

namespace Medidata.RWS.NET.Standard.Core.Objects
{
    /// <summary>
    /// Represents a list of Studies
    /// </summary>
    /// <seealso cref="RwsStudyListItem" />
    /// <seealso cref="Medidata.RWS.NET.Standard.Core.IRwsResponse" />
    public class RwsStudies : IEnumerable<RwsStudyListItem>, IRwsResponse
    {
        List<RwsStudyListItem> StudyListItems = new List<RwsStudyListItem>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RwsStudies"/> class.
        /// </summary>
        /// <param name="xmlString">The XML string.</param>
        public RwsStudies(string xmlString)
        {
            
            ODM.ODM odm = RwsHelpers.Xml.DeserializeFromString<ODM.ODM>(xmlString);

            foreach (var study in odm.Study)
            {
                StudyListItems.Add(new RwsStudyListItem(study));
            }

        }


        /// <summary>
        /// Gets or sets the <see cref="RwsStudyListItem"/> at the specified index.
        /// </summary>
        /// <value>
        /// The <see cref="RwsStudyListItem"/>.
        /// </value>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        public RwsStudyListItem this[int index]
        {
            get { return StudyListItems[index]; }
            set { StudyListItems.Insert(index, value); }
        }

        public HttpResponseMessage ResponseObject { get; }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>
        /// A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the collection.
        /// </returns>
        public IEnumerator<RwsStudyListItem> GetEnumerator()
        {
            return this.StudyListItems.GetEnumerator();
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

    }
}
