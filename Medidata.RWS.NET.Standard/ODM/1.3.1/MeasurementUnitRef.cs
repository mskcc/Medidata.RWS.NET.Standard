namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-MeasurementUnitRef", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("MeasurementUnitRef", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class MeasurementUnitRef
    {
        
        #region Private fields
        private string _measurementUnitOID;
        #endregion
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MeasurementUnitOID
        {
            get
            {
                return this._measurementUnitOID;
            }
            set
            {
                this._measurementUnitOID = value;
            }
        }
    }
}