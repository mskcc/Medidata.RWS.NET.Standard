namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.w3.org/2000/09/xmldsig#")]
    public partial class DSAKeyValueType
    {
        
        #region Private fields
        private byte[] _p;
        
        private byte[] _q;
        
        private byte[] _g;
        
        private byte[] _y;
        
        private byte[] _j;
        
        private byte[] _seed;
        
        private byte[] _pgenCounter;
        #endregion
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] P
        {
            get
            {
                return this._p;
            }
            set
            {
                this._p = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Q
        {
            get
            {
                return this._q;
            }
            set
            {
                this._q = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] G
        {
            get
            {
                return this._g;
            }
            set
            {
                this._g = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Y
        {
            get
            {
                return this._y;
            }
            set
            {
                this._y = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] J
        {
            get
            {
                return this._j;
            }
            set
            {
                this._j = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] Seed
        {
            get
            {
                return this._seed;
            }
            set
            {
                this._seed = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute(DataType="base64Binary")]
        public byte[] PgenCounter
        {
            get
            {
                return this._pgenCounter;
            }
            set
            {
                this._pgenCounter = value;
            }
        }
    }
}