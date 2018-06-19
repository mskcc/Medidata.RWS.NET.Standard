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
    public class ClinicalStudiesRequestTest
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
            public void ClinicalStudiesRequest_can_properly_construct_a_url()
            {
                var request = new ClinicalStudiesRequest();

                Assert.AreEqual("studies", request.UrlPath());

            }


            [TestMethod]
            public async Task ClinicalStudiesRequest_can_format_a_response()
            {

                _httpTest.RespondWith(
                    new StringContent(@"<ODM FileType=""Snapshot"" FileOID="" CreationDateTime="" ODMVersion=""1.3""
                        xmlns:mdsol=""http://www.mdsol.com/ns/odm/metadata"" xmlns=""http://www.cdisc.org/ns/odm/v1.3"">
                         <Study OID=""Lab Test"">
                           <GlobalVariables>
                              <StudyName>Lab Test</StudyName>
                              <StudyDescription />
                              <ProtocolName>Lab Test</ProtocolName>
                           </GlobalVariables>
                         </Study>
                         <Study OID=""Mediflex"">
                           <GlobalVariables>
                              <StudyName>Mediflex</StudyName>
                              <StudyDescription />
                              <ProtocolName>Mediflex</ProtocolName>
                           </GlobalVariables>
                         </Study>
                        </ODM>", Encoding.UTF8, "text/xml"));

                var rwsConnection = new RwsConnection("innovate", "test", "password");
                var request = new ClinicalStudiesRequest();
                var result = await rwsConnection.SendRequestAsync(request) as RwsStudies;
                Assert.IsNotNull(result);
                Assert.IsInstanceOfType(result, typeof(RwsStudies));

                var studies = new[] { "Lab Test", "Mediflex" };

                foreach (var study in result)
                {
                    Assert.IsTrue(studies.Contains(study.Oid));
                }
                   


            }
        }
    }
}
