using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Flurl.Http.Testing;
using Medidata.RWS.NET.Standard.Core;
using Medidata.RWS.NET.Standard.Core.Objects;
using Medidata.RWS.NET.Standard.Core.Requests;
using Medidata.RWS.NET.Standard.Core.Responses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Medidata.RWS.NET.Standard.Tests.Core.Requests
{
    [TestClass]
    public class PostMetaDataRequestTest
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
        public void PostMetaDataRequestTest_can_properly_construct_a_url()
        {
            var request = new PostMetadataRequest("Mediflex(Dev)", "test data");

            Assert.AreEqual("metadata/studies/Mediflex(Dev)/drafts", request.UrlPath());


        }

        [TestMethod]
        public void PostMetaDataRequestTest_can_set_content_type()
        {
            var request = new PostMetadataRequest("Mediflex(Dev)", "test data");

            Assert.IsTrue(request.Headers.TryGetValue("Content-type", out var contentType));

            Assert.AreEqual(contentType, "text/xml");

            Assert.AreEqual(request.RequestBody.ReadAsStringAsync().Result, "test data");
        }


        [TestMethod]
        public async Task PostMetaDataRequestTest_result_can_be_parsed()
        {
            _httpTest.RespondWith(
            @"<Response ReferenceNumber=""82e942b0-48e8-4cf4-b299-51e2b6a89a1b""
              InboundODMFileOID=""""
              IsTransactionSuccessful=""1""
              SuccessStatistics=""Rave objects touched: Subjects=1; Folders=2; Forms=3; Fields=4; LogLines=5"" NewRecords=""6""
              DraftImported=""7"">
            </Response>");
 
            var rwsConnection = new RwsConnection("innovate", "test", "password");
            var request = new PostMetadataRequest("Mediflex(Dev)", "test data");
            var result = await rwsConnection.SendRequestAsync(request) as RwsPostResponse;
                                            
            Assert.IsInstanceOfType(result, typeof(RwsPostResponse));
            Assert.AreEqual(result.SubjectsTouched, 1);
            Assert.AreEqual(result.FoldersTouched, 2);
            Assert.AreEqual(result.FormsTouched, 3);
            Assert.AreEqual(result.FieldsTouched, 4);
            Assert.AreEqual(result.LogLinesTouched, 5);
            Assert.AreEqual(result.NewRecords, "6");
            Assert.AreEqual(result.DraftImported, "7");


        }


    }
}
