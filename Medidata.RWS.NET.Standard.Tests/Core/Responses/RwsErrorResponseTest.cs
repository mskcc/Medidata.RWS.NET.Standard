using System;
using System.Net.Http;
using System.Text;
using Medidata.RWS.NET.Standard.Core.Responses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Medidata.RWS.NET.Standard.Tests.Core.Responses
{
    [TestClass]
    public class RwsErrorResponseTest
    {
        [TestMethod]
        public void RwsErrorResponse_has_an_ErrorDescription_and_ReasonCode()
        {
            var error = new RwsErrorResponse(new HttpResponseMessage
            {
                Content = new StringContent(@"<Response
                                            ReferenceNumber=""0b47fe86-542f-4070-9e7d-16396a5ef08a""
                                            InboundODMFileOID=""Not Supplied""
                                            IsTransactionSuccessful=""0""
                                            ReasonCode=""RWS00005""
                                            ErrorClientResponseMessage=""User is locked out."">
                                        </Response>", Encoding.UTF8, "text/xml")
            });

            Assert.AreEqual("User is locked out.", error.GetErrorDescription());
            Assert.AreEqual("RWS00005", error.ReasonCode);

        }
    }
}
