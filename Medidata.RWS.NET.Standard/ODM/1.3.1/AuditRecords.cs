using System.Collections.Generic;

namespace Medidata.RWS.NET.Standard.ODM
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2612.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="-AuditRecords", Namespace="http://www.cdisc.org/ns/odm/v1.3")]
    [System.Xml.Serialization.XmlRootAttribute("AuditRecords", Namespace="http://www.cdisc.org/ns/odm/v1.3", IsNullable=false)]
    public partial class AuditRecords
    {
        
        #region Private fields
        private List<AuditRecord> _auditRecord;
        #endregion
        
        [System.Xml.Serialization.XmlElementAttribute("AuditRecord")]
        public List<AuditRecord> AuditRecord
        {
            get
            {
                if ((this._auditRecord == null))
                {
                    this._auditRecord = new List<AuditRecord>();
                }
                return this._auditRecord;
            }
            set
            {
                this._auditRecord = value;
            }
        }
    }
}