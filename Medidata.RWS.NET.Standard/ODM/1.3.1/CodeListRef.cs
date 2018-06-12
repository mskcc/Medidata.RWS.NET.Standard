namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-CodeListRef", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("CodeListRef", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class CodeListRef
    {
        
        #region Private fields
        private string _codeListOID;
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
    }
}