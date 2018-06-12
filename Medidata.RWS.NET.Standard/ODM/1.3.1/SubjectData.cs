using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-SubjectData", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("SubjectData", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class SubjectData
    {
        
        #region Private fields
        private AuditRecord _auditRecord;
        
        private Signature _signature;
        
        private InvestigatorRef _investigatorRef;
        
        private SiteRef _siteRef;
        
        private List<Annotation> _annotation;
        
        private List<StudyEventData> _studyEventData;
        
        private string _subjectKey;
        
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
        
        public InvestigatorRef InvestigatorRef
        {
            get
            {
                if ((this._investigatorRef == null))
                {
                    this._investigatorRef = new InvestigatorRef();
                }
                return this._investigatorRef;
            }
            set
            {
                this._investigatorRef = value;
            }
        }
        
        public SiteRef SiteRef
        {
            get
            {
                if ((this._siteRef == null))
                {
                    this._siteRef = new SiteRef();
                }
                return this._siteRef;
            }
            set
            {
                this._siteRef = value;
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
        
        [System.Xml.Serialization.XmlElementAttribute("StudyEventData")]
        public List<StudyEventData> StudyEventData
        {
            get
            {
                if ((this._studyEventData == null))
                {
                    this._studyEventData = new List<StudyEventData>();
                }
                return this._studyEventData;
            }
            set
            {
                this._studyEventData = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SubjectKey
        {
            get
            {
                return this._subjectKey;
            }
            set
            {
                this._subjectKey = value;
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