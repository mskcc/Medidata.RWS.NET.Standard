using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-FormData", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("FormData", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class FormData
    {
        
        #region Private fields
        private AuditRecord _auditRecord;
        
        private Signature _signature;
        
        private ArchiveLayoutRef _archiveLayoutRef;
        
        private List<Annotation> _annotation;
        
        private List<ItemGroupData> _itemGroupData;
        
        private string _formOID;
        
        private string _formRepeatKey;
        
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
        
        public ArchiveLayoutRef ArchiveLayoutRef
        {
            get
            {
                if ((this._archiveLayoutRef == null))
                {
                    this._archiveLayoutRef = new ArchiveLayoutRef();
                }
                return this._archiveLayoutRef;
            }
            set
            {
                this._archiveLayoutRef = value;
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
        
        [System.Xml.Serialization.XmlElementAttribute("ItemGroupData")]
        public List<ItemGroupData> ItemGroupData
        {
            get
            {
                if ((this._itemGroupData == null))
                {
                    this._itemGroupData = new List<ItemGroupData>();
                }
                return this._itemGroupData;
            }
            set
            {
                this._itemGroupData = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FormOID
        {
            get
            {
                return this._formOID;
            }
            set
            {
                this._formOID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FormRepeatKey
        {
            get
            {
                return this._formRepeatKey;
            }
            set
            {
                this._formRepeatKey = value;
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