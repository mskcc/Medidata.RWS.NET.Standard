namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-Association", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("Association", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class Association
    {
        
        #region Private fields
        private KeySet _keySet;
        
        private KeySet _keySet1;
        
        private Annotation _annotation;
        
        private string _studyOID;
        
        private string _metaDataVersionOID;
        #endregion
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public KeySet KeySet
        {
            get
            {
                if ((this._keySet == null))
                {
                    this._keySet = new KeySet();
                }
                return this._keySet;
            }
            set
            {
                this._keySet = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("KeySet", Order=1)]
        public KeySet KeySet1
        {
            get
            {
                if ((this._keySet1 == null))
                {
                    this._keySet1 = new KeySet();
                }
                return this._keySet1;
            }
            set
            {
                this._keySet1 = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public Annotation Annotation
        {
            get
            {
                if ((this._annotation == null))
                {
                    this._annotation = new Annotation();
                }
                return this._annotation;
            }
            set
            {
                this._annotation = value;
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