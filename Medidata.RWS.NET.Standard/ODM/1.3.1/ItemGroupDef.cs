using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-ItemGroupDef", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("ItemGroupDef", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class ItemGroupDef
    {
        
        #region Private fields
        private Description _description;
        
        private List<ItemRef> _itemRef;
        
        private List<Alias> _alias;
        
        private string _oID;
        
        private string _name;
        
        private YesOrNo _repeating;
        
        private YesOrNo _isReferenceData;
        
        private string _sASDatasetName;
        
        private string _domain;
        
        private string _origin;
        
        private string _role;
        
        private string _purpose;
        
        private string _comment;
        #endregion
        
        public Description Description
        {
            get
            {
                if ((this._description == null))
                {
                    this._description = new Description();
                }
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ItemRef")]
        public List<ItemRef> ItemRef
        {
            get
            {
                if ((this._itemRef == null))
                {
                    this._itemRef = new List<ItemRef>();
                }
                return this._itemRef;
            }
            set
            {
                this._itemRef = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Alias")]
        public List<Alias> Alias
        {
            get
            {
                if ((this._alias == null))
                {
                    this._alias = new List<Alias>();
                }
                return this._alias;
            }
            set
            {
                this._alias = value;
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
        public YesOrNo Repeating
        {
            get
            {
                return this._repeating;
            }
            set
            {
                this._repeating = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public YesOrNo IsReferenceData
        {
            get
            {
                return this._isReferenceData;
            }
            set
            {
                this._isReferenceData = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SASDatasetName
        {
            get
            {
                return this._sASDatasetName;
            }
            set
            {
                this._sASDatasetName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Domain
        {
            get
            {
                return this._domain;
            }
            set
            {
                this._domain = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Origin
        {
            get
            {
                return this._origin;
            }
            set
            {
                this._origin = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Role
        {
            get
            {
                return this._role;
            }
            set
            {
                this._role = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Purpose
        {
            get
            {
                return this._purpose;
            }
            set
            {
                this._purpose = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Comment
        {
            get
            {
                return this._comment;
            }
            set
            {
                this._comment = value;
            }
        }
    }
}