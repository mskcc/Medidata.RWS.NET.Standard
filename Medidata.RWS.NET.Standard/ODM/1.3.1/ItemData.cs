using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-ItemData", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("ItemData", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class ItemData
    {
        
        #region Private fields
        private AuditRecord _auditRecord;
        
        private Signature _signature;
        
        private MeasurementUnitRef _measurementUnitRef;
        
        private List<Annotation> _annotation;
        
        private string _itemOID;
        
        private TransactionType _transactionType;
        
        private YesOnly _isNull;
        
        private string _value;
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
        
        public MeasurementUnitRef MeasurementUnitRef
        {
            get
            {
                if ((this._measurementUnitRef == null))
                {
                    this._measurementUnitRef = new MeasurementUnitRef();
                }
                return this._measurementUnitRef;
            }
            set
            {
                this._measurementUnitRef = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ItemOID
        {
            get
            {
                return this._itemOID;
            }
            set
            {
                this._itemOID = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public YesOnly IsNull
        {
            get
            {
                return this._isNull;
            }
            set
            {
                this._isNull = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
}