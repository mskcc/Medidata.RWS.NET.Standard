using System;
using System.Net.Http;
using System.Text;
using Medidata.RWS.NET.Standard.Core.Responses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Medidata.RWS.NET.Standard.Tests.Core.Responses
{
    [TestClass]
    public class RwsPostErrorResponseTest
    {
        [TestMethod]
        public void RwsPostErrorResponse_has_an_ErrorDescription_and_ReasonCode()
        {
            var error = new RwsPostErrorResponse(new HttpResponseMessage
            {
                Content = new StringContent(@"<Response
                                            ReferenceNumber=""0b47fe86-542f-4070-9e7d-16396a5ef08a""
                                            InboundODMFileOID=""Not Supplied""
                                            IsTransactionSuccessful=""0""
                                            ReasonCode=""RWS00024""
                                            ErrorOriginLocation=""/ODM/ClinicalData[1]/SubjectData[1]""
                                            SuccessStatistics=""Rave objects touched: Subjects=0; Folders=0; Forms=0; Fields=0; LogLines=0""
                                            ErrorClientResponseMessage=""Subject already exists."">
                                            </Response>", Encoding.UTF8, "text/xml")
            });

            Assert.AreEqual("Subject already exists.", error.GetErrorDescription());
            Assert.AreEqual("RWS00024", error.ReasonCode);
            Assert.AreEqual("/ODM/ClinicalData[1]/SubjectData[1]", error.ErrorOriginLocation);
            Assert.AreEqual("0b47fe86-542f-4070-9e7d-16396a5ef08a", error.ReferenceNumber);
           //
        }
    }
}
