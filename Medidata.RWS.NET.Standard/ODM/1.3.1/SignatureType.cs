using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignatureType
    {
        
        #region Private fields
        private SignedInfoType _signedInfo;
        
        private SignatureValueType _signatureValue;
        
        private KeyInfoType _keyInfo;
        
        private List<ObjectType> _object;
        
        private string _id;
        #endregion
        
        public SignedInfoType SignedInfo
        {
            get
            {
                if ((this._signedInfo == null))
                {
                    this._signedInfo = new SignedInfoType();
                }
                return this._signedInfo;
            }
            set
            {
                this._signedInfo = value;
            }
        }
        
        public SignatureValueType SignatureValue
        {
            get
            {
                if ((this._signatureValue == null))
                {
                    this._signatureValue = new SignatureValueType();
                }
                return this._signatureValue;
            }
            set
            {
                this._signatureValue = value;
            }
        }
        
        public KeyInfoType KeyInfo
        {
            get
            {
                if ((this._keyInfo == null))
                {
                    this._keyInfo = new KeyInfoType();
                }
                return this._keyInfo;
            }
            set
            {
                this._keyInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Object")]
        public List<ObjectType> Object
        {
            get
            {
                if ((this._object == null))
                {
                    this._object = new List<ObjectType>();
                }
                return this._object;
            }
            set
            {
                this._object = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id
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