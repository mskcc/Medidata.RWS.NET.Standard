using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-Location", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("Location", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class Location
    {
        
        #region Private fields
        private List<MetaDataVersionRef> _metaDataVersionRef;
        
        private string _oID;
        
        private string _name;
        
        private LocationType _locationType;
        #endregion
        
        [System.Xml.Serialization.XmlElementAttribute("MetaDataVersionRef")]
        public List<MetaDataVersionRef> MetaDataVersionRef
        {
            get
            {
                if ((this._metaDataVersionRef == null))
                {
                    this._metaDataVersionRef = new List<MetaDataVersionRef>();
                }
                return this._metaDataVersionRef;
            }
            set
            {
                this._metaDataVersionRef = value;
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
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public LocationType LocationType
        {
            get
            {
                return this._locationType;
            }
            set
            {
                this._locationType = value;
            }
        }
    }
}