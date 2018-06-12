namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-InvestigatorRef", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("InvestigatorRef", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class InvestigatorRef
    {
        
        #region Private fields
        private string _userOID;
        #endregion
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UserOID
        {
            get
            {
                return this._userOID;
            }
            set
            {
                this._userOID = value;
            }
        }
    }
}