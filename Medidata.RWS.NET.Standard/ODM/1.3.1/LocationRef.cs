namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-LocationRef", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("LocationRef", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class LocationRef
    {
        
        #region Private fields
        private string _locationOID;
        #endregion
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationOID
        {
            get
            {
                return this._locationOID;
            }
            set
            {
                this._locationOID = value;
            }
        }
    }
}