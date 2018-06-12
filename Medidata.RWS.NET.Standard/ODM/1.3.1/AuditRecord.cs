namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-AuditRecord", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("AuditRecord", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class AuditRecord
    {
        
        #region Private fields
        private UserRef _userRef;
        
        private LocationRef _locationRef;
        
        private DateTimeStamp _dateTimeStamp;
        
        private ReasonForChange _reasonForChange;
        
        private SourceID _sourceID;
        
        private EditPointType _editPoint;
        
        private YesOrNo _usedImputationMethod;
        
        private string _id;
        #endregion
        
        public UserRef UserRef
        {
            get
            {
                if ((this._userRef == null))
                {
                    this._userRef = new UserRef();
                }
                return this._userRef;
            }
            set
            {
                this._userRef = value;
            }
        }
        
        public LocationRef LocationRef
        {
            get
            {
                if ((this._locationRef == null))
                {
                    this._locationRef = new LocationRef();
                }
                return this._locationRef;
            }
            set
            {
                this._locationRef = value;
            }
        }
        
        public DateTimeStamp DateTimeStamp
        {
            get
            {
                if ((this._dateTimeStamp == null))
                {
                    this._dateTimeStamp = new DateTimeStamp();
                }
                return this._dateTimeStamp;
            }
            set
            {
                this._dateTimeStamp = value;
            }
        }
        
        public ReasonForChange ReasonForChange
        {
            get
            {
                if ((this._reasonForChange == null))
                {
                    this._reasonForChange = new ReasonForChange();
                }
                return this._reasonForChange;
            }
            set
            {
                this._reasonForChange = value;
            }
        }
        
        public SourceID SourceID
        {
            get
            {
                if ((this._sourceID == null))
                {
                    this._sourceID = new SourceID();
                }
                return this._sourceID;
            }
            set
            {
                this._sourceID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public EditPointType EditPoint
        {
            get
            {
                return this._editPoint;
            }
            set
            {
                this._editPoint = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public YesOrNo UsedImputationMethod
        {
            get
            {
                return this._usedImputationMethod;
            }
            set
            {
                this._usedImputationMethod = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string ID
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