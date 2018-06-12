using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-StudyEventData", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("StudyEventData", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class StudyEventData
    {
        
        #region Private fields
        private AuditRecord _auditRecord;
        
        private Signature _signature;
        
        private List<Annotation> _annotation;
        
        private List<FormData> _formData;
        
        private string _studyEventOID;
        
        private string _studyEventRepeatKey;
        
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
        
        [System.Xml.Serialization.XmlElementAttribute("FormData")]
        public List<FormData> FormData
        {
            get
            {
                if ((this._formData == null))
                {
                    this._formData = new List<FormData>();
                }
                return this._formData;
            }
            set
            {
                this._formData = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StudyEventOID
        {
            get
            {
                return this._studyEventOID;
            }
            set
            {
                this._studyEventOID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StudyEventRepeatKey
        {
            get
            {
                return this._studyEventRepeatKey;
            }
            set
            {
                this._studyEventRepeatKey = value;
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