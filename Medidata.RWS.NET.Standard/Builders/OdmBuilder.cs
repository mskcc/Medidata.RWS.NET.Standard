using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Medidata.RWS.NET.Standard.Helpers;
using Medidata.RWS.NET.Standard.ODM;

namespace Medidata.RWS.NET.Standard.Builders
{
    public class OdmBuilder : IBuilder<ODM.ODM>
    {
        /// <summary>
        /// The object to be built.
        /// </summary>
        private ODM.ODM odm;

        /// <summary>
        /// Initializes a new instance of the ODMBuilder class.
        /// </summary>
        public OdmBuilder()
        {
            odm = new ODM.ODM
            {

                FileOID = Guid.NewGuid().ToString(),
                FileType = FileType.Transactional,
                ODMVersion = ODMVersion.Item13,
                CreationDateTime = DateTime.Now,
                ClinicalData = new List<ClinicalData>()
            };
        }

        /// <summary>
        /// Initialize a new instance of the ODMBuilder class, using the supplied ODM object as the 
        /// object context.
        /// </summary>
        /// <param name="_odm"></param>
        public OdmBuilder(ODM.ODM _odm)
        {
            odm = _odm;
        }

        /// <summary>
        /// See <see cref="IBuilder{T}{T}.Build()"></see> for more information.
        /// </summary>
        /// <returns></returns>
        public ODM.ODM Build()
        {
            return odm;
        }


        /// <summary>
        /// Add a "ClinicalData" node using the specified StudyOID value. 
        /// Returns the current builder instance.
        /// </summary>
        /// <param name="StudyOID"></param>
        /// <param name="clinicalDataBuilder"></param>
        /// <returns></returns>
        public OdmBuilder WithClinicalData(string StudyOID, Action<ClinicalDataBuilder> clinicalDataBuilder)
        {
            var cdb = new ClinicalDataBuilder(StudyOID);
            clinicalDataBuilder(cdb);
            odm.ClinicalData = cdb.Build();
            return this;
        }


        /// <summary>
        /// Serialize the ODM object as XML and return a string representation.
        /// </summary>
        /// <returns></returns>
        public string AsXMLString()
        {

            var xmlNameSpace = new XmlSerializerNamespaces();
            xmlNameSpace.Add("mdsol", Constants.MDSOL_NS);
            var serializer = new XmlSerializer(odm.GetType());
            string serialized;
            using (var writer = new StringWriter())
            {
                serializer.Serialize(writer, odm, xmlNameSpace);
                serialized = writer.ToString();
            }
            return serialized;
        }


        public XDocument AsXDocument()
        {
            
            return RwsHelpers.Xml.GetXDocumentFromString(AsXMLString());

        }

    }
}
