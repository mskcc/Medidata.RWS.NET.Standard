using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-StudyEventDef", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("StudyEventDef", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class StudyEventDef
    {
        
        #region Private fields
        private Description _description;
        
        private List<FormRef> _formRef;
        
        private List<Alias> _alias;
        
        private string _oID;
        
        private string _name;
        
        private YesOrNo _repeating;
        
        private EventType _type;
        
        private string _category;
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
        
        [System.Xml.Serialization.XmlElementAttribute("FormRef")]
        public List<FormRef> FormRef
        {
            get
            {
                if ((this._formRef == null))
                {
                    this._formRef = new List<FormRef>();
                }
                return this._formRef;
            }
            set
            {
                this._formRef = value;
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
        public EventType Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Category
        {
            get
            {
                return this._category;
            }
            set
            {
                this._category = value;
            }
        }
    }
}