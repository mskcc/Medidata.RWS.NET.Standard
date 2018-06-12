using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-AdminData", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("AdminData", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class AdminData
    {
        
        #region Private fields
        private List<User> _user;
        
        private List<Location> _location;
        
        private List<SignatureDef> _signatureDef;
        
        private string _studyOID;
        #endregion
        
        [System.Xml.Serialization.XmlElementAttribute("User")]
        public List<User> User
        {
            get
            {
                if ((this._user == null))
                {
                    this._user = new List<User>();
                }
                return this._user;
            }
            set
            {
                this._user = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Location")]
        public List<Location> Location
        {
            get
            {
                if ((this._location == null))
                {
                    this._location = new List<Location>();
                }
                return this._location;
            }
            set
            {
                this._location = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("SignatureDef")]
        public List<SignatureDef> SignatureDef
        {
            get
            {
                if ((this._signatureDef == null))
                {
                    this._signatureDef = new List<SignatureDef>();
                }
                return this._signatureDef;
            }
            set
            {
                this._signatureDef = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StudyOID
        {
            get
            {
                return this._studyOID;
            }
            set
            {
                this._studyOID = value;
            }
        }
    }
}