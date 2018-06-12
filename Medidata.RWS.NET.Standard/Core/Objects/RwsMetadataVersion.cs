using System;
using System.Collections.Generic;
using System.Text;
using Medidata.RWS.NET.Standard.ODM;

namespace Medidata.RWS.NET.Standard.Core.Objects
{
    public class RwsMetadataVersion
    {
        /// <summary>
        /// The Study OID.
        /// </summary>
        public readonly string OID;
        /// <summary>
        /// The Study Name.
        /// </summary>
        public readonly string Name;

        public RwsMetadataVersion(MetaDataVersion version)
        {
            OID = version.OID;
            Name = version.Name;
        }


    }
}
