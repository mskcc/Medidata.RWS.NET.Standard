namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class RSAKeyValueType
    {
        
        #region Private fields
        private byte[] _modulus;
        
        private byte[] _exponent;
        #endregion
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Modulus
        {
            get
            {
                return this._modulus;
            }
            set
            {
                this._modulus = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Exponent
        {
            get
            {
                return this._exponent;
            }
            set
            {
                this._exponent = value;
            }
        }
    }
}