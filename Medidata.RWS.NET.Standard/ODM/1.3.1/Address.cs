using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-Address", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("Address", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class Address
    {
        
        #region Private fields
        private List<StreetName> _streetName;
        
        private City _city;
        
        private StateProv _stateProv;
        
        private Country _country;
        
        private PostalCode _postalCode;
        
        private OtherText _otherText;
        #endregion
        
        [System.Xml.Serialization.XmlElementAttribute("StreetName")]
        public List<StreetName> StreetName
        {
            get
            {
                if ((this._streetName == null))
                {
                    this._streetName = new List<StreetName>();
                }
                return this._streetName;
            }
            set
            {
                this._streetName = value;
            }
        }
        
        public City City
        {
            get
            {
                if ((this._city == null))
                {
                    this._city = new City();
                }
                return this._city;
            }
            set
            {
                this._city = value;
            }
        }
        
        public StateProv StateProv
        {
            get
            {
                if ((this._stateProv == null))
                {
                    this._stateProv = new StateProv();
                }
                return this._stateProv;
            }
            set
            {
                this._stateProv = value;
            }
        }
        
        public Country Country
        {
            get
            {
                if ((this._country == null))
                {
                    this._country = new Country();
                }
                return this._country;
            }
            set
            {
                this._country = value;
            }
        }
        
        public PostalCode PostalCode
        {
            get
            {
                if ((this._postalCode == null))
                {
                    this._postalCode = new PostalCode();
                }
                return this._postalCode;
            }
            set
            {
                this._postalCode = value;
            }
        }
        
        public OtherText OtherText
        {
            get
            {
                if ((this._otherText == null))
                {
                    this._otherText = new OtherText();
                }
                return this._otherText;
            }
            set
            {
                this._otherText = value;
            }
        }
    }
}