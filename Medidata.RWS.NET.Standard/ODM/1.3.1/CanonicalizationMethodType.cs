using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class CanonicalizationMethodType
    {
        
        #region Private fields
        private List<System.Xml.XmlNode> _any;
        
        private string _algorithm;
        #endregion
        
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public List<System.Xml.XmlNode> Any
        {
            get
            {
                if ((this._any == null))
                {
                    this._any = new List<System.Xml.XmlNode>();
                }
                return this._any;
            }
            set
            {
                this._any = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Algorithm
        {
            get
            {
                return this._algorithm;
            }
            set
            {
                this._algorithm = value;
            }
        }
    }
}