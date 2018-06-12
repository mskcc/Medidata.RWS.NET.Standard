namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-Flag", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("Flag", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class Flag
    {
        
        #region Private fields
        private FlagValue _flagValue;
        
        private FlagType _flagType;
        #endregion
        
        public FlagValue FlagValue
        {
            get
            {
                if ((this._flagValue == null))
                {
                    this._flagValue = new FlagValue();
                }
                return this._flagValue;
            }
            set
            {
                this._flagValue = value;
            }
        }
        
        public FlagType FlagType
        {
            get
            {
                if ((this._flagType == null))
                {
                    this._flagType = new FlagType();
                }
                return this._flagType;
            }
            set
            {
                this._flagType = value;
            }
        }
    }
}