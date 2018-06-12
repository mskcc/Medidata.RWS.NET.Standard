using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-RangeCheck", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("RangeCheck", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class RangeCheck
    {
        
        #region Private fields
        private List<object> _items;
        
        private MeasurementUnitRef _measurementUnitRef;
        
        private ErrorMessage _errorMessage;
        
        private Comparator _comparator;
        
        private SoftOrHard _softHard;
        #endregion
        
        [System.Xml.Serialization.XmlElementAttribute("CheckValue", typeof(CheckValue))]
        [System.Xml.Serialization.XmlElementAttribute("FormalExpression", typeof(FormalExpression))]
        public List<object> Items
        {
            get
            {
                if ((this._items == null))
                {
                    this._items = new List<object>();
                }
                return this._items;
            }
            set
            {
                this._items = value;
            }
        }
        
        public MeasurementUnitRef MeasurementUnitRef
        {
            get
            {
                if ((this._measurementUnitRef == null))
                {
                    this._measurementUnitRef = new MeasurementUnitRef();
                }
                return this._measurementUnitRef;
            }
            set
            {
                this._measurementUnitRef = value;
            }
        }
        
        public ErrorMessage ErrorMessage
        {
            get
            {
                if ((this._errorMessage == null))
                {
                    this._errorMessage = new ErrorMessage();
                }
                return this._errorMessage;
            }
            set
            {
                this._errorMessage = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public Comparator Comparator
        {
            get
            {
                return this._comparator;
            }
            set
            {
                this._comparator = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SoftOrHard SoftHard
        {
            get
            {
                return this._softHard;
            }
            set
            {
                this._softHard = value;
            }
        }
    }
}