namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-Alias", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("Alias", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class Alias
    {
        
        #region Private fields
        private string _context;
        
        private string _name;
        #endregion
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Context
        {
            get
            {
                return this._context;
            }
            set
            {
                this._context = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
    }
}