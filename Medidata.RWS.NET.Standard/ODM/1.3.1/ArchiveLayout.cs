namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-ArchiveLayout", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("ArchiveLayout", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class ArchiveLayout
    {
        
        #region Private fields
        private string _oID;
        
        private string _pdfFileName;
        
        private string _presentationOID;
        #endregion
        
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
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string PdfFileName
        {
            get
            {
                return this._pdfFileName;
            }
            set
            {
                this._pdfFileName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PresentationOID
        {
            get
            {
                return this._presentationOID;
            }
            set
            {
                this._presentationOID = value;
            }
        }
    }
}