using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using Medidata.RWS.NET.Standard.Helpers;

namespace Medidata.RWS.NET.Standard.Core.Objects
{
    public class RwsStudyMetadataVersions : IEnumerable<RwsMetadataVersion>, IRwsResponse
    {
        /// <summary>
        /// The study
        /// </summary>
        public readonly RwsStudyListItem Study;

        /// <summary>
        /// The meta data versions
        /// </summary>
        public readonly List<RwsMetadataVersion> MetaDataVersions = new List<RwsMetadataVersion>();

        public IEnumerator<RwsMetadataVersion> GetEnumerator()
        {
            return MetaDataVersions.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public HttpResponseMessage ResponseObject { get; }


        public RwsStudyMetadataVersions(string xmlString)
        {

            ODM.ODM odm = RwsHelpers.Xml.DeserializeFromString<ODM.ODM>(xmlString);

            if (odm.Study.Count == 0) return;

            Study = new RwsStudyListItem(odm.Study.First());

            foreach (var version in odm.Study.First().MetaDataVersion)
            {
                MetaDataVersions.Add(new RwsMetadataVersion(version));
            }

        }
    }
}
