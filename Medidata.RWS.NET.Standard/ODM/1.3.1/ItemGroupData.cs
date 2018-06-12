using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-ItemGroupData", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("ItemGroupData", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class ItemGroupData
    {
        
        #region Private fields
        private AuditRecord _auditRecord;
        
        private Signature _signature;
        
        private List<Annotation> _annotation;
        
        private List<object> _items;
        
        private string _itemGroupOID;
        
        private string _itemGroupRepeatKey;
        
        private TransactionType _transactionType;
        #endregion
        
        public AuditRecord AuditRecord
        {
            get
            {
                if ((this._auditRecord == null))
                {
                    this._auditRecord = new AuditRecord();
                }
                return this._auditRecord;
            }
            set
            {
                this._auditRecord = value;
            }
        }
        
        public Signature Signature
        {
            get
            {
                if ((this._signature == null))
                {
                    this._signature = new Signature();
                }
                return this._signature;
            }
            set
            {
                this._signature = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Annotation")]
        public List<Annotation> Annotation
        {
            get
            {
                if ((this._annotation == null))
                {
                    this._annotation = new List<Annotation>();
                }
                return this._annotation;
            }
            set
            {
                this._annotation = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ItemData", typeof(ItemData))]
        [System.Xml.Serialization.XmlElementAttribute("ItemDataAny", typeof(ItemDataAny))]
        [System.Xml.Serialization.XmlElementAttribute("ItemDataBase64Binary", typeof(ItemDataBase64Binary))]
        [System.Xml.Serialization.XmlElementAttribute("ItemDataBase64Float", typeof(ItemDataBase64Float))]
        [System.Xml.Serialization.XmlElementAttribute("ItemDataBoolean", typeof(ItemDataBoolean))]
        [System.Xml.Serialization.XmlElementAttribute("ItemDataDate", typeof(ItemDataDate))]
        [System.Xml.Serialization.XmlElementAttribute("ItemDataDatetime", typeof(ItemDataDatetime))]
        [System.Xml.Serialization.XmlElementAttribute("ItemDataDouble", typeof(ItemDataDouble))]
        [System.Xml.Serialization.XmlElementAttribute("ItemDataDurationDatetime", typeof(ItemDataDurationDatetime))]
        [System.Xml.Serialization.XmlElementAttribute("ItemDataFloat", typeof(ItemDataFloat))]
        [System.Xml.Serialization.XmlElementAttribute("ItemDataHexBinary", typeof(ItemDataHexBinary))]
        [System.Xml.Serialization.XmlElementAttribute("ItemDataHexFloat", typeof(ItemDataHexFloat))]
        [System.Xml.Serialization.XmlElementAttribute("ItemDataIncompleteDate", typeof(ItemDataIncompleteDate))]
        [System.Xml.Serialization.XmlElementAttribute("ItemDataIncompleteDatetime", typeof(ItemDataIncompleteDatetime))]
        [System.Xml.Serialization.XmlElementAttribute("ItemDataIncompleteTime", typeof(ItemDataIncompleteTime))]
        [System.Xml.Serialization.XmlElementAttribute("ItemDataInteger", typeof(ItemDataInteger))]
        [System.Xml.Serialization.XmlElementAttribute("ItemDataIntervalDatetime", typeof(ItemDataIntervalDatetime))]
        [System.Xml.Serialization.XmlElementAttribute("ItemDataPartialDate", typeof(ItemDataPartialDate))]
        [System.Xml.Serialization.XmlElementAttribute("ItemDataPartialDatetime", typeof(ItemDataPartialDatetime))]
        [System.Xml.Serialization.XmlElementAttribute("ItemDataPartialTime", typeof(ItemDataPartialTime))]
        [System.Xml.Serialization.XmlElementAttribute("ItemDataString", typeof(ItemDataString))]
        [System.Xml.Serialization.XmlElementAttribute("ItemDataTime", typeof(ItemDataTime))]
        [System.Xml.Serialization.XmlElementAttribute("ItemDataURI", typeof(ItemDataURI))]
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ItemGroupOID
        {
            get
            {
                return this._itemGroupOID;
            }
            set
            {
                this._itemGroupOID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ItemGroupRepeatKey
        {
            get
            {
                return this._itemGroupRepeatKey;
            }
            set
            {
                this._itemGroupRepeatKey = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TransactionType TransactionType
        {
            get
            {
                return this._transactionType;
            }
            set
            {
                this._transactionType = value;
            }
        }
    }
}