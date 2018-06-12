namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-Picture", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("Picture", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class Picture
    {
        
        #region Private fields
        private string _pictureFileName;
        
        private string _imageType;
        #endregion
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string PictureFileName
        {
            get
            {
                return this._pictureFileName;
            }
            set
            {
                this._pictureFileName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ImageType
        {
            get
            {
                return this._imageType;
            }
            set
            {
                this._imageType = value;
            }
        }
    }
}