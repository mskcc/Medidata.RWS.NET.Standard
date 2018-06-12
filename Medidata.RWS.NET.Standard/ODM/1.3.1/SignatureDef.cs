namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-SignatureDef", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("SignatureDef", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class SignatureDef
    {
        
        #region Private fields
        private Meaning _meaning;
        
        private LegalReason _legalReason;
        
        private string _oID;
        
        private SignMethod _methodology;
        #endregion
        
        public Meaning Meaning
        {
            get
            {
                if ((this._meaning == null))
                {
                    this._meaning = new Meaning();
                }
                return this._meaning;
            }
            set
            {
                this._meaning = value;
            }
        }
        
        public LegalReason LegalReason
        {
            get
            {
                if ((this._legalReason == null))
                {
                    this._legalReason = new LegalReason();
                }
                return this._legalReason;
            }
            set
            {
                this._legalReason = value;
            }
        }
        
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SignMethod Methodology
        {
            get
            {
                return this._methodology;
            }
            set
            {
                this._methodology = value;
            }
        }
    }
}