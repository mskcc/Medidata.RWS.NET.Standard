namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-FlagValue", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("FlagValue", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class FlagValue
    {
        
        #region Private fields
        private string _codeListOID;
        
        private string _value;
        #endregion
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CodeListOID
        {
            get
            {
                return this._codeListOID;
            }
            set
            {
                this._codeListOID = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
}