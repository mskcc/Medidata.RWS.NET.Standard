using System;
using System.Xml.Serialization;

namespace Medidata.RWS.NET.Standard.ODM
{
    public partial class SubjectData
    {
        [XmlAttribute(Namespace = Constants.MDSOL_NS, AttributeName = "SubjectName")]
        public string SubjectName { get; set; }

        [XmlAttribute(Namespace = Constants.MDSOL_NS, AttributeName = "SubjectKeyType")]
        public string SubjectKeyType { get; set; }

        [XmlAttribute(Namespace = Constants.MDSOL_NS, AttributeName = "Status")]
        public string Status { get; set; }
    }
}
