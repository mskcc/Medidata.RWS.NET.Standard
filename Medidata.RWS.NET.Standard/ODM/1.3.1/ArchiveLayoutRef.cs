namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-ArchiveLayoutRef", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("ArchiveLayoutRef", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class ArchiveLayoutRef
    {
        
        #region Private fields
        private string _archiveLayoutOID;
        #endregion
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ArchiveLayoutOID
        {
            get
            {
                return this._archiveLayoutOID;
            }
            set
            {
                this._archiveLayoutOID = value;
            }
        }
    }
}