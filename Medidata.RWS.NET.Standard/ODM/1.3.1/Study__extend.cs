using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Medidata.RWS.NET.Standard.ODM
{
    public partial class Study
    {
        [XmlAttribute(Namespace = "http://www.mdsol.com/ns/odm/metadata", AttributeName = "ProjectType")]
        public string ProjectType
        {
            get; set;
        }
    }
}
