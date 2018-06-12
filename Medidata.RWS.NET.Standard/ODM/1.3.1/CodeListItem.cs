using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-CodeListItem", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("CodeListItem", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class CodeListItem
    {
        
        #region Private fields
        private Decode _decode;
        
        private List<Alias> _alias;
        
        private string _codedValue;
        
        private decimal _rank;
        #endregion
        
        public Decode Decode
        {
            get
            {
                if ((this._decode == null))
                {
                    this._decode = new Decode();
                }
                return this._decode;
            }
            set
            {
                this._decode = value;
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
        public string CodedValue
        {
            get
            {
                return this._codedValue;
            }
            set
            {
                this._codedValue = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal Rank
        {
            get
            {
                return this._rank;
            }
            set
            {
                this._rank = value;
            }
        }
    }
}