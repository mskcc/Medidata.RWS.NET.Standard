using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-BasicDefinitions", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("BasicDefinitions", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class BasicDefinitions
    {
        
        #region Private fields
        private List<MeasurementUnit> _measurementUnit;
        #endregion
        
        [System.Xml.Serialization.XmlElementAttribute("MeasurementUnit")]
        public List<MeasurementUnit> MeasurementUnit
        {
            get
            {
                if ((this._measurementUnit == null))
                {
                    this._measurementUnit = new List<MeasurementUnit>();
                }
                return this._measurementUnit;
            }
            set
            {
                this._measurementUnit = value;
            }
        }
    }
}