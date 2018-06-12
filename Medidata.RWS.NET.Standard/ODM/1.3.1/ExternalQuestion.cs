namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-ExternalQuestion", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("ExternalQuestion", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class ExternalQuestion
    {
        
        #region Private fields
        private string _dictionary;
        
        private string _version;
        
        private string _code;
        #endregion
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Dictionary
        {
            get
            {
                return this._dictionary;
            }
            set
            {
                this._dictionary = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Version
        {
            get
            {
                return this._version;
            }
            set
            {
                this._version = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
    }
}