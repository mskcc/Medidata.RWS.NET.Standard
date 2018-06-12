using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-Description", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("Description", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class Description
    {
        
        #region Private fields
        private List<TranslatedText> _translatedText;
        #endregion
        
        [System.Xml.Serialization.XmlElementAttribute("TranslatedText")]
        public List<TranslatedText> TranslatedText
        {
            get
            {
                if ((this._translatedText == null))
                {
                    this._translatedText = new List<TranslatedText>();
                }
                return this._translatedText;
            }
            set
            {
                this._translatedText = value;
            }
        }
    }
}