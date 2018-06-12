namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-GlobalVariables", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("GlobalVariables", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class GlobalVariables
    {
        
        #region Private fields
        private StudyName _studyName;
        
        private StudyDescription _studyDescription;
        
        private ProtocolName _protocolName;
        #endregion
        
        public StudyName StudyName
        {
            get
            {
                if ((this._studyName == null))
                {
                    this._studyName = new StudyName();
                }
                return this._studyName;
            }
            set
            {
                this._studyName = value;
            }
        }
        
        public StudyDescription StudyDescription
        {
            get
            {
                if ((this._studyDescription == null))
                {
                    this._studyDescription = new StudyDescription();
                }
                return this._studyDescription;
            }
            set
            {
                this._studyDescription = value;
            }
        }
        
        public ProtocolName ProtocolName
        {
            get
            {
                if ((this._protocolName == null))
                {
                    this._protocolName = new ProtocolName();
                }
                return this._protocolName;
            }
            set
            {
                this._protocolName = value;
            }
        }
    }
}