namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-Include", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("Include", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class Include
    {
        
        #region Private fields
        private string _studyOID;
        
        private string _metaDataVersionOID;
        #endregion
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StudyOID
        {
            get
            {
                return this._studyOID;
            }
            set
            {
                this._studyOID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MetaDataVersionOID
        {
            get
            {
                return this._metaDataVersionOID;
            }
            set
            {
                this._metaDataVersionOID = value;
            }
        }
    }
}