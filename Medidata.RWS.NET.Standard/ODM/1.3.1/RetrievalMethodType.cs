using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class RetrievalMethodType
    {
        
        #region Private fields
        private List<TransformType> _transforms;
        
        private string _uRI;
        
        private string _type;
        #endregion
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable=false)]
        public List<TransformType> Transforms
        {
            get
            {
                if ((this._transforms == null))
                {
                    this._transforms = new List<TransformType>();
                }
                return this._transforms;
            }
            set
            {
                this._transforms = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string URI
        {
            get
            {
                return this._uRI;
            }
            set
            {
                this._uRI = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
    }
}