using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl.Http.Testing;
using Medidata.RWS.NET.Standard.Core;
using Medidata.RWS.NET.Standard.Core.Requests;
using Medidata.RWS.NET.Standard.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Medidata.RWS.NET.Standard.Tests.Core
{
    [TestClass]
    public class RwsHelpersTest
    {

        [TestMethod]
        public void RwsHelpers_can_get_environment_name_from_study_and_protocol()
        {

            string studyName = "Mediflex(DEV)";
            string protocolName = "Mediflex";

            Assert.AreEqual("DEV", RwsHelpers.Strings.GetEnvironmentFromStudyNameAndProtocol(studyName, protocolName));

        }

        [TestMethod]
        public void RwsHelpers_can_get_environment_name_from_study_oid()
        {

            string studyOid = "Mediflex(DEV)";

            Assert.AreEqual("DEV", RwsHelpers.Strings.GetEnvironmentNameFromStudyOid(studyOid));

        }


        [TestMethod]
        public void RwsHelpers_can_get_project_name_from_study_oid()
        {

            string studyOid = "Mediflex(DEV)";

            Assert.AreEqual("Mediflex", RwsHelpers.Strings.GetProjectNameFromStudyOid(studyOid));

        }


        [TestMethod]
        public void RwsHelpers_can_deserialize_an_ODM_object_from_an_xml_string()
        {

            string odmXml = @"<ODM ODMVersion=""1.3"" Granularity=""Metadata"" FileType=""Snapshot""
                FileOID=""d26b4d33-376d-4037-9747-684411190179""
                CreationDateTime=""2013-04-08T01:29:13""
                xmlns=""http://www.cdisc.org/ns/odm/v1.3""
                xmlns:mdsol=""http://www.mdsol.com/ns/odm/metadata"">
                    <Study OID=""Mediflex"">
                        <GlobalVariables>
                            <StudyName>Mediflex</StudyName>
                            <StudyDescription></StudyDescription>
                            <ProtocolName>Mediflex</ProtocolName>
                        </GlobalVariables>
                        <MetaDataVersion OID=""1213"" Name=""1.0_DRAFT"" />
                        <MetaDataVersion OID=""1194"" Name=""CF_TEST_DRAFT1"" />
                        <MetaDataVersion OID=""1164"" Name=""Initial"" />
                    </Study>
                </ODM>";

            var odm = RwsHelpers.Xml.DeserializeFromString<ODM.ODM>(odmXml);

            Assert.IsInstanceOfType(odm, typeof(ODM.ODM));
            Assert.AreEqual("Mediflex", odm.Study.First().OID);
            Assert.AreEqual("1213", odm.Study.First().MetaDataVersion.First().OID);

        }



    }
}
