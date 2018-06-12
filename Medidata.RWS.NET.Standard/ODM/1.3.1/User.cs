using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-User", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("User", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class User
    {
        
        #region Private fields
        private LoginName _loginName;
        
        private DisplayName _displayName;
        
        private FullName _fullName;
        
        private FirstName _firstName;
        
        private LastName _lastName;
        
        private Organization _organization;
        
        private List<Address> _address;
        
        private List<Email> _email;
        
        private Picture _picture;
        
        private Pager _pager;
        
        private List<Fax> _fax;
        
        private List<Phone> _phone;
        
        private List<LocationRef> _locationRef;
        
        private List<Certificate> _certificate;
        
        private string _oID;
        
        private UserType _userType;
        #endregion
        
        public LoginName LoginName
        {
            get
            {
                if ((this._loginName == null))
                {
                    this._loginName = new LoginName();
                }
                return this._loginName;
            }
            set
            {
                this._loginName = value;
            }
        }
        
        public DisplayName DisplayName
        {
            get
            {
                if ((this._displayName == null))
                {
                    this._displayName = new DisplayName();
                }
                return this._displayName;
            }
            set
            {
                this._displayName = value;
            }
        }
        
        public FullName FullName
        {
            get
            {
                if ((this._fullName == null))
                {
                    this._fullName = new FullName();
                }
                return this._fullName;
            }
            set
            {
                this._fullName = value;
            }
        }
        
        public FirstName FirstName
        {
            get
            {
                if ((this._firstName == null))
                {
                    this._firstName = new FirstName();
                }
                return this._firstName;
            }
            set
            {
                this._firstName = value;
            }
        }
        
        public LastName LastName
        {
            get
            {
                if ((this._lastName == null))
                {
                    this._lastName = new LastName();
                }
                return this._lastName;
            }
            set
            {
                this._lastName = value;
            }
        }
        
        public Organization Organization
        {
            get
            {
                if ((this._organization == null))
                {
                    this._organization = new Organization();
                }
                return this._organization;
            }
            set
            {
                this._organization = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Address")]
        public List<Address> Address
        {
            get
            {
                if ((this._address == null))
                {
                    this._address = new List<Address>();
                }
                return this._address;
            }
            set
            {
                this._address = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Email")]
        public List<Email> Email
        {
            get
            {
                if ((this._email == null))
                {
                    this._email = new List<Email>();
                }
                return this._email;
            }
            set
            {
                this._email = value;
            }
        }
        
        public Picture Picture
        {
            get
            {
                if ((this._picture == null))
                {
                    this._picture = new Picture();
                }
                return this._picture;
            }
            set
            {
                this._picture = value;
            }
        }
        
        public Pager Pager
        {
            get
            {
                if ((this._pager == null))
                {
                    this._pager = new Pager();
                }
                return this._pager;
            }
            set
            {
                this._pager = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Fax")]
        public List<Fax> Fax
        {
            get
            {
                if ((this._fax == null))
                {
                    this._fax = new List<Fax>();
                }
                return this._fax;
            }
            set
            {
                this._fax = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Phone")]
        public List<Phone> Phone
        {
            get
            {
                if ((this._phone == null))
                {
                    this._phone = new List<Phone>();
                }
                return this._phone;
            }
            set
            {
                this._phone = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("LocationRef")]
        public List<LocationRef> LocationRef
        {
            get
            {
                if ((this._locationRef == null))
                {
                    this._locationRef = new List<LocationRef>();
                }
                return this._locationRef;
            }
            set
            {
                this._locationRef = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Certificate")]
        public List<Certificate> Certificate
        {
            get
            {
                if ((this._certificate == null))
                {
                    this._certificate = new List<Certificate>();
                }
                return this._certificate;
            }
            set
            {
                this._certificate = value;
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
        public UserType UserType
        {
            get
            {
                return this._userType;
            }
            set
            {
                this._userType = value;
            }
        }
    }
}