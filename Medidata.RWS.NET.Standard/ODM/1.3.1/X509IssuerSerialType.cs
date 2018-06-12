namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class X509IssuerSerialType
    {
        
        #region Private fields
        private string _x509IssuerName;
        
        private string _x509SerialNumber;
        #endregion
        
        public string X509IssuerName
        {
            get
            {
                return this._x509IssuerName;
            }
            set
            {
                this._x509IssuerName = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
        public string X509SerialNumber
        {
            get
            {
                return this._x509SerialNumber;
            }
            set
            {
                this._x509SerialNumber = value;
            }
        }
    }
}