using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-Study", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("Study", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class Study
    {
        
        #region Private fields
        private GlobalVariables _globalVariables;
        
        private BasicDefinitions _basicDefinitions;
        
        private List<MetaDataVersion> _metaDataVersion;
        
        private string _oID;
        #endregion
        
        public GlobalVariables GlobalVariables
        {
            get
            {
                if ((this._globalVariables == null))
                {
                    this._globalVariables = new GlobalVariables();
                }
                return this._globalVariables;
            }
            set
            {
                this._globalVariables = value;
            }
        }
        
        public BasicDefinitions BasicDefinitions
        {
            get
            {
                if ((this._basicDefinitions == null))
                {
                    this._basicDefinitions = new BasicDefinitions();
                }
                return this._basicDefinitions;
            }
            set
            {
                this._basicDefinitions = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("MetaDataVersion")]
        public List<MetaDataVersion> MetaDataVersion
        {
            get
            {
                if ((this._metaDataVersion == null))
                {
                    this._metaDataVersion = new List<MetaDataVersion>();
                }
                return this._metaDataVersion;
            }
            set
            {
                this._metaDataVersion = value;
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