using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-MethodDef", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("MethodDef", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class MethodDef
    {
        
        #region Private fields
        private Description _description;
        
        private List<FormalExpression> _formalExpression;
        
        private List<Alias> _alias;
        
        private string _oID;
        
        private string _name;
        
        private MethodType _type;
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
        
        [System.Xml.Serialization.XmlElementAttribute("FormalExpression")]
        public List<FormalExpression> FormalExpression
        {
            get
            {
                if ((this._formalExpression == null))
                {
                    this._formalExpression = new List<FormalExpression>();
                }
                return this._formalExpression;
            }
            set
            {
                this._formalExpression = value;
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
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MethodType Type
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