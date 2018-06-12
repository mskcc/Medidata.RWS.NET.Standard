namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-FormRef", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("FormRef", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class FormRef
    {
        
        #region Private fields
        private string _formOID;
        
        private string _orderNumber;
        
        private YesOrNo _mandatory;
        
        private string _collectionExceptionConditionOID;
        #endregion
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string FormOID
        {
            get
            {
                return this._formOID;
            }
            set
            {
                this._formOID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string OrderNumber
        {
            get
            {
                return this._orderNumber;
            }
            set
            {
                this._orderNumber = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public YesOrNo Mandatory
        {
            get
            {
                return this._mandatory;
            }
            set
            {
                this._mandatory = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string CollectionExceptionConditionOID
        {
            get
            {
                return this._collectionExceptionConditionOID;
            }
            set
            {
                this._collectionExceptionConditionOID = value;
            }
        }
    }
}