namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SPKIDataType
    {
        
        #region Private fields
        private byte[][] _sPKISexp;
        
        private System.Xml.XmlElement _any;
        #endregion
        
        [System.Xml.Serialization.XmlElementAttribute("SPKISexp", DataType="base64Binary")]
        public byte[][] SPKISexp
        {
            get
            {
                return this._sPKISexp;
            }
            set
            {
                this._sPKISexp = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement Any
        {
            get
            {
                return this._any;
            }
            set
            {
                this._any = value;
            }
        }
    }
}