using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-Annotations", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("Annotations", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class Annotations
    {
        
        #region Private fields
        private List<Annotation> _annotation;
        #endregion
        
        [System.Xml.Serialization.XmlElementAttribute("Annotation")]
        public List<Annotation> Annotation
        {
            get
            {
                if ((this._annotation == null))
                {
                    this._annotation = new List<Annotation>();
                }
                return this._annotation;
            }
            set
            {
                this._annotation = value;
            }
        }
    }
}