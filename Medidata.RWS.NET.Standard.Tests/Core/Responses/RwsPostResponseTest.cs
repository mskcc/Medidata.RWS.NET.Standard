using System;
using System.Net.Http;
using System.Text;
using Medidata.RWS.NET.Standard.Core.Responses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Medidata.RWS.NET.Standard.Tests.Core.Responses
{
    [TestClass]
    public class RwsPostResponseTest
    {
        [TestMethod]
        public void RwsPostResponse_can_parse_a_post_response()
        {
            var response = new RwsPostResponse(new HttpResponseMessage
            {
                Content = new StringContent(@"<Response
                                            ReferenceNumber=""0b47fe86-542f-4070-9e7d-16396a5ef08a""
                                            InboundODMFileOID=""Not Supplied""
                                            IsTransactionSuccessful=""1""
                                            SuccessStatistics=""Rave objects touched: Subjects = 0; Folders = 1; Forms = 2; Fields = 3; LogLines = 4"" NewRecords=""5""
                                            SubjectNumberInStudy = ""6"" SubjectNumberInStudySite = ""7"">
                                        </Response>", Encoding.UTF8, "text/xml")
            });

            Assert.AreEqual(true, response.IsTransactionSuccessful);
        }

        [TestMethod]
        public void RwsPostResponse_can_handle_unexpected_success_statistics()
        {
                                                                                                                                                                        
            try {
                var response = new RwsPostResponse(new HttpResponseMessage
                {
                    Content = new StringContent(@"<Response
                                            ReferenceNumber=""0b47fe86-542f-4070-9e7d-16396a5ef08a""
                                            InboundODMFileOID=""Not Supplied""
                                            IsTransactionSuccessful=""1""
                                            SuccessStatistics=""Rave objects touched: Subjects = 0; Folders = 1; Forms = 2; Wackyval = 100; Fields = 3; LogLines = 4"" NewRecords=""5""
                                            SubjectNumberInStudy = ""6"" SubjectNumberInStudySite = ""7"">
                                        </Response>", Encoding.UTF8, "text/xml")
                });
            } catch (Exception ex)
            {
                Assert.AreEqual("Unknown RAVE Object Wackyval in response Subjects = 0; Folders = 1; Forms = 2; Wackyval = 100; Fields = 3; LogLines = 4", ex.Message);
            }



        }
    }
}
