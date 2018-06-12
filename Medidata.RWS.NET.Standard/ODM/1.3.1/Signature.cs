namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-Signature", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("Signature", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class Signature
    {
        
        #region Private fields
        private UserRef _userRef;
        
        private LocationRef _locationRef;
        
        private SignatureRef _signatureRef;
        
        private DateTimeStamp _dateTimeStamp;
        
        private CryptoBindingManifest _cryptoBindingManifest;
        
        private string _id;
        #endregion
        
        public UserRef UserRef
        {
            get
            {
                if ((this._userRef == null))
                {
                    this._userRef = new UserRef();
                }
                return this._userRef;
            }
            set
            {
                this._userRef = value;
            }
        }
        
        public LocationRef LocationRef
        {
            get
            {
                if ((this._locationRef == null))
                {
                    this._locationRef = new LocationRef();
                }
                return this._locationRef;
            }
            set
            {
                this._locationRef = value;
            }
        }
        
        public SignatureRef SignatureRef
        {
            get
            {
                if ((this._signatureRef == null))
                {
                    this._signatureRef = new SignatureRef();
                }
                return this._signatureRef;
            }
            set
            {
                this._signatureRef = value;
            }
        }
        
        public DateTimeStamp DateTimeStamp
        {
            get
            {
                if ((this._dateTimeStamp == null))
                {
                    this._dateTimeStamp = new DateTimeStamp();
                }
                return this._dateTimeStamp;
            }
            set
            {
                this._dateTimeStamp = value;
            }
        }
        
        public CryptoBindingManifest CryptoBindingManifest
        {
            get
            {
                if ((this._cryptoBindingManifest == null))
                {
                    this._cryptoBindingManifest = new CryptoBindingManifest();
                }
                return this._cryptoBindingManifest;
            }
            set
            {
                this._cryptoBindingManifest = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
    }
}