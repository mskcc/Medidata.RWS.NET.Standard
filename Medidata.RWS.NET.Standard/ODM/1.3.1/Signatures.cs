using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-Signatures", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("Signatures", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class Signatures
    {
        
        #region Private fields
        private List<Signature> _signature;
        #endregion
        
        [System.Xml.Serialization.XmlElementAttribute("Signature")]
        public List<Signature> Signature
        {
            get
            {
                if ((this._signature == null))
                {
                    this._signature = new List<Signature>();
                }
                return this._signature;
            }
            set
            {
                this._signature = value;
            }
        }
    }
}