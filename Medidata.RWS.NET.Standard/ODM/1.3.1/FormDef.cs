using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-FormDef", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("FormDef", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class FormDef
    {
        
        #region Private fields
        private Description _description;
        
        private List<ItemGroupRef> _itemGroupRef;
        
        private List<ArchiveLayout> _archiveLayout;
        
        private List<Alias> _alias;
        
        private string _oID;
        
        private string _name;
        
        private YesOrNo _repeating;
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
        
        [System.Xml.Serialization.XmlElementAttribute("ItemGroupRef")]
        public List<ItemGroupRef> ItemGroupRef
        {
            get
            {
                if ((this._itemGroupRef == null))
                {
                    this._itemGroupRef = new List<ItemGroupRef>();
                }
                return this._itemGroupRef;
            }
            set
            {
                this._itemGroupRef = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ArchiveLayout")]
        public List<ArchiveLayout> ArchiveLayout
        {
            get
            {
                if ((this._archiveLayout == null))
                {
                    this._archiveLayout = new List<ArchiveLayout>();
                }
                return this._archiveLayout;
            }
            set
            {
                this._archiveLayout = value;
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
    }
}