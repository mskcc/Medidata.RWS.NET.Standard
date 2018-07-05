using System.Collections.Generic;
using System.Xml.Serialization;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class SignedInfoType
    {
        
        #region Private fields
        private CanonicalizationMethodType _canonicalizationMethod;
        
        private SignatureMethodType _signatureMethod;
        
        private List<ReferenceType> _reference;
        
        private string _id;
        #endregion

        [XmlIgnore]
        public CanonicalizationMethodType CanonicalizationMethod
        {
            get
            {
                if ((this._canonicalizationMethod == null))
                {
                    this._canonicalizationMethod = new CanonicalizationMethodType();
                }
                return this._canonicalizationMethod;
            }
            set
            {
                this._canonicalizationMethod = value;
            }
        }
        
        public SignatureMethodType SignatureMethod
        {
            get
            {
                if ((this._signatureMethod == null))
                {
                    this._signatureMethod = new SignatureMethodType();
                }
                return this._signatureMethod;
            }
            set
            {
                this._signatureMethod = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Reference")]
        public List<ReferenceType> Reference
        {
            get
            {
                if ((this._reference == null))
                {
                    this._reference = new List<ReferenceType>();
                }
                return this._reference;
            }
            set
            {
                this._reference = value;
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