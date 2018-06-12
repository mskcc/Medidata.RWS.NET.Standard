using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-MetaDataVersion", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("MetaDataVersion", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class MetaDataVersion
    {
        
        #region Private fields
        private Include _include;
        
        private Protocol _protocol;
        
        private List<StudyEventDef> _studyEventDef;
        
        private List<FormDef> _formDef;
        
        private List<ItemGroupDef> _itemGroupDef;
        
        private List<ItemDef> _itemDef;
        
        private List<CodeList> _codeList;
        
        private List<ImputationMethod> _imputationMethod;
        
        private List<Presentation> _presentation;
        
        private List<ConditionDef> _conditionDef;
        
        private List<MethodDef> _methodDef;
        
        private string _oID;
        
        private string _name;
        
        private string _description;
        #endregion
        
        public Include Include
        {
            get
            {
                if ((this._include == null))
                {
                    this._include = new Include();
                }
                return this._include;
            }
            set
            {
                this._include = value;
            }
        }
        
        public Protocol Protocol
        {
            get
            {
                if ((this._protocol == null))
                {
                    this._protocol = new Protocol();
                }
                return this._protocol;
            }
            set
            {
                this._protocol = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("StudyEventDef")]
        public List<StudyEventDef> StudyEventDef
        {
            get
            {
                if ((this._studyEventDef == null))
                {
                    this._studyEventDef = new List<StudyEventDef>();
                }
                return this._studyEventDef;
            }
            set
            {
                this._studyEventDef = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("FormDef")]
        public List<FormDef> FormDef
        {
            get
            {
                if ((this._formDef == null))
                {
                    this._formDef = new List<FormDef>();
                }
                return this._formDef;
            }
            set
            {
                this._formDef = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ItemGroupDef")]
        public List<ItemGroupDef> ItemGroupDef
        {
            get
            {
                if ((this._itemGroupDef == null))
                {
                    this._itemGroupDef = new List<ItemGroupDef>();
                }
                return this._itemGroupDef;
            }
            set
            {
                this._itemGroupDef = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ItemDef")]
        public List<ItemDef> ItemDef
        {
            get
            {
                if ((this._itemDef == null))
                {
                    this._itemDef = new List<ItemDef>();
                }
                return this._itemDef;
            }
            set
            {
                this._itemDef = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CodeList")]
        public List<CodeList> CodeList
        {
            get
            {
                if ((this._codeList == null))
                {
                    this._codeList = new List<CodeList>();
                }
                return this._codeList;
            }
            set
            {
                this._codeList = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ImputationMethod")]
        public List<ImputationMethod> ImputationMethod
        {
            get
            {
                if ((this._imputationMethod == null))
                {
                    this._imputationMethod = new List<ImputationMethod>();
                }
                return this._imputationMethod;
            }
            set
            {
                this._imputationMethod = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Presentation")]
        public List<Presentation> Presentation
        {
            get
            {
                if ((this._presentation == null))
                {
                    this._presentation = new List<Presentation>();
                }
                return this._presentation;
            }
            set
            {
                this._presentation = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ConditionDef")]
        public List<ConditionDef> ConditionDef
        {
            get
            {
                if ((this._conditionDef == null))
                {
                    this._conditionDef = new List<ConditionDef>();
                }
                return this._conditionDef;
            }
            set
            {
                this._conditionDef = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("MethodDef")]
        public List<MethodDef> MethodDef
        {
            get
            {
                if ((this._methodDef == null))
                {
                    this._methodDef = new List<MethodDef>();
                }
                return this._methodDef;
            }
            set
            {
                this._methodDef = value;
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
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
    }
}