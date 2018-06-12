using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-Annotation", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("Annotation", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class Annotation
    {
        
        #region Private fields
        private Comment _comment;
        
        private List<Flag> _flag;
        
        private string _seqNum;
        
        private TransactionType _transactionType;
        
        private string _id;
        #endregion
        
        public Comment Comment
        {
            get
            {
                if ((this._comment == null))
                {
                    this._comment = new Comment();
                }
                return this._comment;
            }
            set
            {
                this._comment = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Flag")]
        public List<Flag> Flag
        {
            get
            {
                if ((this._flag == null))
                {
                    this._flag = new List<Flag>();
                }
                return this._flag;
            }
            set
            {
                this._flag = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string SeqNum
        {
            get
            {
                return this._seqNum;
            }
            set
            {
                this._seqNum = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TransactionType TransactionType
        {
            get
            {
                return this._transactionType;
            }
            set
            {
                this._transactionType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string ID
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }
    }
}