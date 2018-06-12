namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-ExternalCodeList", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("ExternalCodeList", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class ExternalCodeList
    {
        
        #region Private fields
        private string _dictionary;
        
        private string _version;
        
        private string _href;
        
        private string _ref;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string href
        {
            get
            {
                return this._href;
            }
            set
            {
                this._href = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string @ref
        {
            get
            {
                return this._ref;
            }
            set
            {
                this._ref = value;
            }
        }
    }
}