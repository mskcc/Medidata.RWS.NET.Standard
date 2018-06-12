namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-ItemRef", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("ItemRef", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class ItemRef
    {
        
        #region Private fields
        private string _itemOID;
        
        private string _keySequence;
        
        private string _methodOID;
        
        private string _imputationMethodOID;
        
        private string _role;
        
        private string _roleCodeListOID;
        
        private string _orderNumber;
        
        private YesOrNo _mandatory;
        
        private string _collectionExceptionConditionOID;
        #endregion
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ItemOID
        {
            get
            {
                return this._itemOID;
            }
            set
            {
                this._itemOID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string KeySequence
        {
            get
            {
                return this._keySequence;
            }
            set
            {
                this._keySequence = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string MethodOID
        {
            get
            {
                return this._methodOID;
            }
            set
            {
                this._methodOID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ImputationMethodOID
        {
            get
            {
                return this._imputationMethodOID;
            }
            set
            {
                this._imputationMethodOID = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Role
        {
            get
            {
                return this._role;
            }
            set
            {
                this._role = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RoleCodeListOID
        {
            get
            {
                return this._roleCodeListOID;
            }
            set
            {
                this._roleCodeListOID = value;
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