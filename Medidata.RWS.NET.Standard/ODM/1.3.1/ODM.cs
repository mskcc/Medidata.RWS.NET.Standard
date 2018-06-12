using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class ODM
    {
        
        #region Private fields
        private List<Study> _study;
        
        private List<AdminData> _adminData;
        
        private List<ReferenceData> _referenceData;
        
        private List<ClinicalData> _clinicalData;
        
        private List<Association> _association;
        
        private List<SignatureType> _signature;
        
        private string _description;
        
        private FileType _fileType;
        
        private Granularity _granularity;
        
        private YesOnly _archival;
        
        private string _fileOID;
        
        private System.DateTime _creationDateTime;
        
        private string _priorFileOID;
        
        private System.DateTime _asOfDateTime;
        
        private ODMVersion _oDMVersion;
        
        private string _originator;
        
        private string _sourceSystem;
        
        private string _sourceSystemVersion;
        
        private string _id;
        #endregion
        
        [System.Xml.Serialization.XmlElementAttribute("Study")]
        public List<Study> Study
        {
            get
            {
                if ((this._study == null))
                {
                    this._study = new List<Study>();
                }
                return this._study;
            }
            set
            {
                this._study = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AdminData")]
        public List<AdminData> AdminData
        {
            get
            {
                if ((this._adminData == null))
                {
                    this._adminData = new List<AdminData>();
                }
                return this._adminData;
            }
            set
            {
                this._adminData = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ReferenceData")]
        public List<ReferenceData> ReferenceData
        {
            get
            {
                if ((this._referenceData == null))
                {
                    this._referenceData = new List<ReferenceData>();
                }
                return this._referenceData;
            }
            set
            {
                this._referenceData = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ClinicalData")]
        public List<ClinicalData> ClinicalData
        {
            get
            {
                if ((this._clinicalData == null))
                {
                    this._clinicalData = new List<ClinicalData>();
                }
                return this._clinicalData;
            }
            set
            {
                this._clinicalData = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Association")]
        public List<Association> Association
        {
            get
            {
                if ((this._association == null))
                {
                    this._association = new List<Association>();
                }
                return this._association;
            }
            set
            {
                this._association = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace="http://www.w3.org/2000/09/xmldsig#")]
        public List<SignatureType> Signature
        {
            get
            {
                if ((this._signature == null))
                {
                    this._signature = new List<SignatureType>();
                }
                return this._signature;
            }
            set
            {
                this._signature = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FileType FileType
        {
            get
            {
                return this._fileType;
            }
            set
            {
                this._fileType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public Granularity Granularity
        {
            get
            {
                return this._granularity;
            }
            set
            {
                this._granularity = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public YesOnly Archival
        {
            get
            {
                return this._archival;
            }
            set
            {
                this._archival = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FileOID
        {
            get
            {
                return this._fileOID;
            }
            set
            {
                this._fileOID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime CreationDateTime
        {
            get
            {
                return this._creationDateTime;
            }
            set
            {
                this._creationDateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PriorFileOID
        {
            get
            {
                return this._priorFileOID;
            }
            set
            {
                this._priorFileOID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime AsOfDateTime
        {
            get
            {
                return this._asOfDateTime;
            }
            set
            {
                this._asOfDateTime = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ODMVersion ODMVersion
        {
            get
            {
                return this._oDMVersion;
            }
            set
            {
                this._oDMVersion = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Originator
        {
            get
            {
                return this._originator;
            }
            set
            {
                this._originator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SourceSystem
        {
            get
            {
                return this._sourceSystem;
            }
            set
            {
                this._sourceSystem = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SourceSystemVersion
        {
            get
            {
                return this._sourceSystemVersion;
            }
            set
            {
                this._sourceSystemVersion = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
    }
}