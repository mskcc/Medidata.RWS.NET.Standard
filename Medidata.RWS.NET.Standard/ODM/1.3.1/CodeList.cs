using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-CodeList", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("CodeList", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class CodeList
    {
        
        #region Private fields
        private Description _description;
        
        private List<object> _items;
        
        private List<Alias> _alias;
        
        private string _oID;
        
        private string _name;
        
        private CLDataType _dataType;
        
        private string _sASFormatName;
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
        
        [System.Xml.Serialization.XmlElementAttribute("CodeListItem", typeof(CodeListItem))]
        [System.Xml.Serialization.XmlElementAttribute("EnumeratedItem", typeof(EnumeratedItem))]
        [System.Xml.Serialization.XmlElementAttribute("ExternalCodeList", typeof(ExternalCodeList))]
        public List<object> Items
        {
            get
            {
                if ((this._items == null))
                {
                    this._items = new List<object>();
                }
                return this._items;
            }
            set
            {
                this._items = value;
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
        public CLDataType DataType
        {
            get
            {
                return this._dataType;
            }
            set
            {
                this._dataType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SASFormatName
        {
            get
            {
                return this._sASFormatName;
            }
            set
            {
                this._sASFormatName = value;
            }
        }
    }
}