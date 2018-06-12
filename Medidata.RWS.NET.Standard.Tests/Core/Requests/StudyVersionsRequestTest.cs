using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl.Http.Testing;
using Medidata.RWS.NET.Standard.Core;
using Medidata.RWS.NET.Standard.Core.Objects;
using Medidata.RWS.NET.Standard.Core.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Medidata.RWS.NET.Standard.Tests.Core.Requests
{
    [TestClass]
    public class StudyVersionsRequestTest
    {

        private HttpTest _httpTest;

        [TestInitialize]
        public void SetUp()
        {
            _httpTest = new HttpTest();
        }

        [TestCleanup]
        public void TearDown()
        {
            _httpTest.Dispose();
        }


        [TestMethod]
        public void StudyVersionsRequest_can_properly_construct_a_url()
        {
            var request = new StudyVersionsRequest("Mediflex(Dev)");

            Assert.AreEqual("metadata/studies/Mediflex(Dev)/versions", request.UrlPath());

        }


        [TestMethod]
        public async Task StudyVersionsRequest_can_format_a_response()
        {

            _httpTest.RespondWith(
                @"<ODM ODMVersion=""1.3"" Granularity=""Metadata"" FileType=""Snapshot""
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
                </ODM>"
            );

            var rwsConnection = new RwsConnection("innovate", "test", "password");
            var request = new StudyVersionsRequest("Mediflex(Dev)");
            var response = await rwsConnection.SendRequestAsync(request);
            var result = request.Result(response.ResponseObject) as RwsStudyMetadataVersions;
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(RwsStudyMetadataVersions));
            Assert.AreEqual(result.Study.Oid, "Mediflex");

            var versionOids = new[] { "1213", "1194", "1164" };
            var versionNames = new[] { "1.0_DRAFT", "CF_TEST_DRAFT1", "Initial" };

            foreach (var version in result)
            {
                Assert.IsTrue(versionOids.Contains(version.OID));
                Assert.IsTrue(versionNames.Contains(version.Name));
            }


        }



    }
}
