using System;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http.Testing;
using Medidata.RWS.NET.Standard.Core;
using Medidata.RWS.NET.Standard.Core.Objects;
using Medidata.RWS.NET.Standard.Core.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Medidata.RWS.NET.Standard.Tests.Core.Requests
{
    [TestClass]
    public class MetadataStudiesRequestTest
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
        public void ClinicalStudiesRequest_can_properly_construct_a_url()
        {
            var request = new MetadataStudiesRequest();

            Assert.AreEqual("metadata/studies", request.UrlPath());

        }

        [TestMethod]
        public async Task MetadataStudiesRequest_can_format_a_response()
        {
            _httpTest.RespondWith(
                    new StringContent(@"<?xml version=""1.0"" encoding=""utf-8""?>
                <ODM ODMVersion=""1.3"" Granularity=""Metadata"" FileType=""Snapshot"" FileOID=""d5457ec2-feee-4a0f-88c1-fbedc391974b"" CreationDateTime=""2018-06-20T12:02:50"" xmlns=""http://www.cdisc.org/ns/odm/v1.3"" xmlns:mdsol=""http://www.mdsol.com/ns/odm/metadata"">
                    <Study OID=""Lab Test(Dev)"">
                        <GlobalVariables>
                            <StudyName>Lab Test(Dev)</StudyName>
                            <StudyDescription></StudyDescription>
                            <ProtocolName>Lab Test</ProtocolName>
                        </GlobalVariables>
                    </Study>
                    <Study OID=""Mediflex(Prod)"">
                        <GlobalVariables>
                            <StudyName>Mediflex(Prod)</StudyName>
                            <StudyDescription></StudyDescription>
                            <ProtocolName>Mediflex</ProtocolName>
                        </GlobalVariables>
                    </Study>
                </ODM>", Encoding.UTF8, "text/xml"));

            var rwsConnection = new RwsConnection("innovate", "test", "password");
            var request = new MetadataStudiesRequest();
            var result = await rwsConnection.SendRequestAsync(request) as RwsStudies;
            Assert.IsNotNull(result);
            Assert.IsInstanceOfType(result, typeof(RwsStudies));

            var studies = new[] { "Lab Test(Dev)", "Mediflex(Prod)" };
            var environments = new[] { "Dev", "Prod" };

            foreach (var study in result)
            {
                Assert.IsTrue(studies.Contains(study.Oid));
                Assert.IsTrue(environments.Contains(study.Environment),
                              $"Unexpected environment ({study.Environment})");
            }


        }
  
    }
}
