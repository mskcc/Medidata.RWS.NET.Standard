using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-ItemDef", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("ItemDef", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class ItemDef
    {
        
        #region Private fields
        private Description _description;
        
        private Question _question;
        
        private ExternalQuestion _externalQuestion;
        
        private List<MeasurementUnitRef> _measurementUnitRef;
        
        private List<RangeCheck> _rangeCheck;
        
        private CodeListRef _codeListRef;
        
        private List<Role> _role;
        
        private List<Alias> _alias;
        
        private string _oID;
        
        private string _name;
        
        private DataType _dataType;
        
        private string _length;
        
        private string _significantDigits;
        
        private string _sASFieldName;
        
        private string _sDSVarName;
        
        private string _origin;
        
        private string _comment;
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
        
        public Question Question
        {
            get
            {
                if ((this._question == null))
                {
                    this._question = new Question();
                }
                return this._question;
            }
            set
            {
                this._question = value;
            }
        }
        
        public ExternalQuestion ExternalQuestion
        {
            get
            {
                if ((this._externalQuestion == null))
                {
                    this._externalQuestion = new ExternalQuestion();
                }
                return this._externalQuestion;
            }
            set
            {
                this._externalQuestion = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("MeasurementUnitRef")]
        public List<MeasurementUnitRef> MeasurementUnitRef
        {
            get
            {
                if ((this._measurementUnitRef == null))
                {
                    this._measurementUnitRef = new List<MeasurementUnitRef>();
                }
                return this._measurementUnitRef;
            }
            set
            {
                this._measurementUnitRef = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RangeCheck")]
        public List<RangeCheck> RangeCheck
        {
            get
            {
                if ((this._rangeCheck == null))
                {
                    this._rangeCheck = new List<RangeCheck>();
                }
                return this._rangeCheck;
            }
            set
            {
                this._rangeCheck = value;
            }
        }
        
        public CodeListRef CodeListRef
        {
            get
            {
                if ((this._codeListRef == null))
                {
                    this._codeListRef = new CodeListRef();
                }
                return this._codeListRef;
            }
            set
            {
                this._codeListRef = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Role")]
        public List<Role> Role
        {
            get
            {
                if ((this._role == null))
                {
                    this._role = new List<Role>();
                }
                return this._role;
            }
            set
            {
                this._role = value;
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
        public DataType DataType
        {
            get
            {
                return this._dataType;
            }
            set
            {
                this._dataType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string Length
        {
            get
            {
                return this._length;
            }
            set
            {
                this._length = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string SignificantDigits
        {
            get
            {
                return this._significantDigits;
            }
            set
            {
                this._significantDigits = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SASFieldName
        {
            get
            {
                return this._sASFieldName;
            }
            set
            {
                this._sASFieldName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SDSVarName
        {
            get
            {
                return this._sDSVarName;
            }
            set
            {
                this._sDSVarName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Origin
        {
            get
            {
                return this._origin;
            }
            set
            {
                this._origin = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Comment
        {
            get
            {
                return this._comment;
            }
            set
            {
                this._comment = value;
            }
        }
    }
}