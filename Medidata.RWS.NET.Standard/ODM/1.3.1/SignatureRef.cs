namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-SignatureRef", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("SignatureRef", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class SignatureRef
    {
        
        #region Private fields
        private string _signatureOID;
        #endregion
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SignatureOID
        {
            get
            {
                return this._signatureOID;
            }
            set
            {
                this._signatureOID = value;
            }
        }
    }
}