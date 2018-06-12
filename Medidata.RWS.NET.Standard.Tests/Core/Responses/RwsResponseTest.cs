using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl.Http.Testing;
using Medidata.RWS.NET.Standard.Core;
using Medidata.RWS.NET.Standard.Core.Requests;
using Medidata.RWS.NET.Standard.Core.Responses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Medidata.RWS.NET.Standard.Tests.Core.Responses
{
    [TestClass]
    public class RwsResponseTest
    {
        [TestMethod]
        public void RwsResponse_can_parse_a_response_object()
        {

            const string response = @"<Response ReferenceNumber=""82e942b0-48e8-4cf4-b299-51e2b6a89a1b""
                    InboundODMFileOID=""""
                    IsTransactionSuccessful=""1""
                    SuccessStatistics=""Rave objects touched: Subjects=1; Folders=2; Forms=3; Fields=4; LogLines=5"" NewRecords="""">
             </Response>";

            var mockResponse = new Mock<HttpResponseMessage>();

            mockResponse.Object.Content = new StringContent(response);

            var resp = new RwsResponse(mockResponse.Object);

            Assert.AreEqual("82e942b0-48e8-4cf4-b299-51e2b6a89a1b", resp.ReferenceNumber);
            Assert.IsTrue(resp.IsTransactionSuccessful);
            Assert.AreEqual(1, resp.SubjectsTouched);
            Assert.AreEqual(2, resp.FoldersTouched);
            Assert.AreEqual(3, resp.FormsTouched);
            Assert.AreEqual(4, resp.FieldsTouched);
            Assert.AreEqual(5, resp.LogLinesTouched);
        }


    }
}
