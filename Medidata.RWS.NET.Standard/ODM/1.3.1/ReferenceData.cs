using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-ReferenceData", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("ReferenceData", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class ReferenceData
    {
        
        #region Private fields
        private List<ItemGroupData> _itemGroupData;
        
        private List<AuditRecord> _auditRecords;
        
        private List<Signature> _signatures;
        
        private List<Annotation> _annotations;
        
        private string _studyOID;
        
        private string _metaDataVersionOID;
        #endregion
        
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
        
        [System.Xml.Serialization.XmlArrayItemAttribute("AuditRecord", typeof(AuditRecord), IsNullable=false)]
        public List<AuditRecord> AuditRecords
        {
            get
            {
                if ((this._auditRecords == null))
                {
                    this._auditRecords = new List<AuditRecord>();
                }
                return this._auditRecords;
            }
            set
            {
                this._auditRecords = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Signature", typeof(Signature), IsNullable=false)]
        public List<Signature> Signatures
        {
            get
            {
                if ((this._signatures == null))
                {
                    this._signatures = new List<Signature>();
                }
                return this._signatures;
            }
            set
            {
                this._signatures = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Annotation", typeof(Annotation), IsNullable=false)]
        public List<Annotation> Annotations
        {
            get
            {
                if ((this._annotations == null))
                {
                    this._annotations = new List<Annotation>();
                }
                return this._annotations;
            }
            set
            {
                this._annotations = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string StudyOID
        {
            get
            {
                return this._studyOID;
            }
            set
            {
                this._studyOID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MetaDataVersionOID
        {
            get
            {
                return this._metaDataVersionOID;
            }
            set
            {
                this._metaDataVersionOID = value;
            }
        }
    }
}