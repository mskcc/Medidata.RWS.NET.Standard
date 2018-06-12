namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-PostalCode", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("PostalCode", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class PostalCode
    {
        
        #region Private fields
        private string _value;
        #endregion
        
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