namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-KeySet", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("KeySet", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class KeySet
    {
        
        #region Private fields
        private string _studyOID;
        
        private string _subjectKey;
        
        private string _studyEventOID;
        
        private string _studyEventRepeatKey;
        
        private string _formOID;
        
        private string _formRepeatKey;
        
        private string _itemGroupOID;
        
        private string _itemGroupRepeatKey;
        
        private string _itemOID;
        
        private string _oID;
        #endregion
        
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
    }
}