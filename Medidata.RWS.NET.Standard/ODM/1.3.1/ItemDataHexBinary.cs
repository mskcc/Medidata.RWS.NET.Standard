namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-ItemDataHexBinary", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("ItemDataHexBinary", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class ItemDataHexBinary
    {
        
        #region Private fields
        private string _itemOID;
        
        private TransactionType _transactionType;
        
        private string _auditRecordID;
        
        private string _signatureID;
        
        private string _annotationID;
        
        private string _measurementUnitOID;
        
        private byte[] _value;
        #endregion
        
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
        public string AuditRecordID
        {
            get
            {
                return this._auditRecordID;
            }
            set
            {
                this._auditRecordID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
        public string SignatureID
        {
            get
            {
                return this._signatureID;
            }
            set
            {
                this._signatureID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
        public string AnnotationID
        {
            get
            {
                return this._annotationID;
            }
            set
            {
                this._annotationID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MeasurementUnitOID
        {
            get
            {
                return this._measurementUnitOID;
            }
            set
            {
                this._measurementUnitOID = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute(DataType="hexBinary")]
        public byte[] Value
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