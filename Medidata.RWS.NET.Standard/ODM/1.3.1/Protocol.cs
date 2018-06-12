using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-Protocol", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("Protocol", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class Protocol
    {
        
        #region Private fields
        private Description _description;
        
        private List<StudyEventRef> _studyEventRef;
        
        private List<Alias> _alias;
        #endregion
        
        public Description Description
        {
            get
            {
                if ((this._description == null))
                {
                    this._description = new Description();
                }
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("StudyEventRef")]
        public List<StudyEventRef> StudyEventRef
        {
            get
            {
                if ((this._studyEventRef == null))
                {
                    this._studyEventRef = new List<StudyEventRef>();
                }
                return this._studyEventRef;
            }
            set
            {
                this._studyEventRef = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Alias")]
        public List<Alias> Alias
        {
            get
            {
                if ((this._alias == null))
                {
                    this._alias = new List<Alias>();
                }
                return this._alias;
            }
            set
            {
                this._alias = value;
            }
        }
    }
}