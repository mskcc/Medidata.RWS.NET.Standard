namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-ImputationMethod", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("ImputationMethod", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class ImputationMethod
    {
        
        #region Private fields
        private string _oID;
        
        private string _value;
        #endregion
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OID
        {
            get
            {
                return this._oID;
            }
            set
            {
                this._oID = value;
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