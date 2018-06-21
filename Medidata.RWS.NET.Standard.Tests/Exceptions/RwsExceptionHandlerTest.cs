using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Medidata.RWS.NET.Standard.Core.Responses;
using Medidata.RWS.NET.Standard.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Medidata.RWS.NET.Standard.Tests.Exceptions
{
    [TestClass]
    public class RwsExceptionHandlerTest
    {


        [TestMethod]
        public void RwsExceptionHandler_raises_authorization_exception_for_401_responses()
        {

            var content = new StringContent(@"Authorization Header not provided");

            var responseMessage401 = new HttpResponseMessage
            {
                Content = content,
                StatusCode = System.Net.HttpStatusCode.Unauthorized,
                RequestMessage = new HttpRequestMessage { Method = HttpMethod.Get }
            };

            try
            {
                RwsExceptionHandler.Parse(responseMessage401);
            }
            catch (RwsAuthorizationException ex)
            {
                Assert.AreEqual("Authorization Header not provided", ex.Message);
            }

        }


        [TestMethod]
        public void RwsExceptionHandler_raises_exception_for_401_responses_with_ODM_content()
        {

            var responseMessage = new HttpResponseMessage
            {
                Content = new StringContent(@"<?xml version=""1.0"" encoding=""utf-8""?>
                    <ODM xmlns:mdsol=""http://www.mdsol.com/ns/odm/metadata""
                         FileType=""Snapshot""
                         CreationDateTime=""2013-04-08T10:28:49.578-00:00""
                         FileOID=""4d13722a-ceb6-4419-a917-b6ad5d0bc30e""
                         ODMVersion=""1.3""
                         mdsol:ErrorDescription=""Incorrect login and password combination. [RWS00008]""
                         xmlns=""http://www.cdisc.org/ns/odm/v1.3"" />", Encoding.UTF8, "text/xml"),
                StatusCode = System.Net.HttpStatusCode.Unauthorized,
                RequestMessage = new HttpRequestMessage { Method = HttpMethod.Get }
            };

            try
            {
                RwsExceptionHandler.Parse(responseMessage);
            }
            catch (RwsException ex)
            {
                Assert.AreEqual("Incorrect login and password combination. [RWS00008]", ex.Message);
            }


        }





        [TestMethod]
        public void RwsExceptionHandler_raises_exception_for_401_responses_with_RWS_content()
        {

            var content = new StringContent(@"<Response
                                            ReferenceNumber=""0b47fe86-542f-4070-9e7d-16396a5ef08a""
                                            InboundODMFileOID=""Not Supplied""
                                            IsTransactionSuccessful=""0""
                                            ReasonCode=""RWS00005""
                                            ErrorClientResponseMessage=""User is locked out."">
                                        </Response>", Encoding.UTF8, "text/xml");

            var responseMessage401 = new HttpResponseMessage
            {
                Content = content,
                StatusCode = System.Net.HttpStatusCode.Unauthorized,
                RequestMessage = new HttpRequestMessage { Method = HttpMethod.Get }
            };

            try
            {
                RwsExceptionHandler.Parse(responseMessage401);
            }
            catch (RwsException ex)
            {
                Assert.AreEqual("User is locked out.", ex.Message);
                var errorResponse = ex.ErrorResponse as RwsErrorResponse;
                Assert.AreEqual("RWS00005", errorResponse.ReasonCode);
            }
        }


        [TestMethod]
        public void RwsExceptionHandler_raises_exception_for_400_responses_with_RWS_content()
        {

            var content = new StringContent(@"<Response
                                            ReferenceNumber=""0b47fe86-542f-4070-9e7d-16396a5ef08a""
                                            InboundODMFileOID=""Not Supplied""
                                            IsTransactionSuccessful=""0""
                                            ReasonCode=""RWS00092""
                                            ErrorClientResponseMessage=""CRF version not found"">
                                        </Response>", Encoding.UTF8, "text/xml");

            var responseMessage400 = new HttpResponseMessage
            {
                Content = content,
                StatusCode = System.Net.HttpStatusCode.BadRequest,
                RequestMessage = new HttpRequestMessage { Method = HttpMethod.Get }
            };

            try
            {
                RwsExceptionHandler.Parse(responseMessage400);
            }
            catch (RwsException ex)
            {
                Assert.AreEqual("CRF version not found", ex.Message);
                var errorResponse = ex.ErrorResponse as RwsErrorResponse;
                Assert.AreEqual("RWS00092", errorResponse.ReasonCode);
            }
        }



        [TestMethod]
        public void RwsExceptionHandler_raises_exception_for_404_responses_with_RWS_content()
        {

            var content = new StringContent(@"<Response
                                            ReferenceNumber=""0b47fe86-542f-4070-9e7d-16396a5ef08a""
                                            InboundODMFileOID=""Not Supplied""
                                            IsTransactionSuccessful=""0""
                                            ReasonCode=""RWS00092""
                                            ErrorClientResponseMessage=""CRF version not found"">
                                        </Response>", Encoding.UTF8, "text/xml");
            
            var responseMessage404 = new HttpResponseMessage
            {
                Content = content,
                StatusCode = System.Net.HttpStatusCode.NotFound,
                RequestMessage = new HttpRequestMessage { Method = HttpMethod.Get }
            };

            try
            {
                RwsExceptionHandler.Parse(responseMessage404);
            }
            catch (RwsException ex)
            {
                Assert.AreEqual("CRF version not found", ex.Message);
                var errorResponse = ex.ErrorResponse as RwsErrorResponse;
                Assert.AreEqual("RWS00092", errorResponse.ReasonCode);
            }
        }




        [TestMethod]
        public void RwsExceptionHandler_raises_exception_for_400_responses_with_html()
        {

            var content = new StringContent(@"<!DOCTYPE html>
        <html>
        <head>
            <meta charset=""utf-8"" />
            <title>OOPS! Error Occurred. Sorry about this.</title>
        </head>
        <body>
            <h2>OOPS! Error Occurred</h2>
        </body>
        </html>", Encoding.UTF8);

            var responseMessage400 = new HttpResponseMessage
            {
                Content = content,
                StatusCode = System.Net.HttpStatusCode.BadRequest
            };

            try
            {
                RwsExceptionHandler.Parse(responseMessage400);
            }
            catch (RwsException ex)
            {
                Assert.AreEqual("IIS Error", ex.Message);
            }
        }



        [TestMethod]
        public void RwsExceptionHandler_raises_exception_for_404_responses_with_html()
        {

            var content = new StringContent(@"<!DOCTYPE html>
        <html>
        <head>
            <meta charset=""utf-8"" />
            <title>OOPS! Error Occurred. Sorry about this.</title>
        </head>
        <body>
            <h2>OOPS! Error Occurred</h2>
        </body>
        </html>", Encoding.UTF8);

            var responseMessage404 = new HttpResponseMessage
            {
                Content = content,
                StatusCode = System.Net.HttpStatusCode.NotFound
            };

            try
            {
                RwsExceptionHandler.Parse(responseMessage404);
            }
            catch (RwsException ex)
            {
                Assert.AreEqual("IIS Error", ex.Message);
            }
        }


        [TestMethod]
        [ExpectedException(typeof(RwsException))]
        public void RwsExceptionHandler_raises_exception_for_404_responses_with_generic_text()
        {

            var content = new StringContent(@"Unknown text.");

            var responseMessage404 = new HttpResponseMessage
            {
                Content = content,
                StatusCode = System.Net.HttpStatusCode.NotFound
            };

            RwsExceptionHandler.Parse(responseMessage404);
        }

        [TestMethod]
        [ExpectedException(typeof(RwsException))]
        public void RwsExceptionHandler_raises_exception_for_400_responses_with_generic_text()
        {

            var content = new StringContent(@"Unknown text.");

            var responseMessage404 = new HttpResponseMessage
            {
                Content = content,
                StatusCode = System.Net.HttpStatusCode.BadRequest
            };

            RwsExceptionHandler.Parse(responseMessage404);
        }

        [TestMethod]
        public void RwsExceptionHandler_raises_exception_for_500_responses()
        {

            var content = new StringContent(@"Some error");

            var responseMessage500 = new HttpResponseMessage
            {
                Content = content,
                StatusCode = System.Net.HttpStatusCode.InternalServerError
            };

            try
            {
                RwsExceptionHandler.Parse(responseMessage500);
            }
            catch (RwsException ex)
            {
                Assert.AreEqual("Server Error (500)", ex.Message);
            }
        }


   


        [TestMethod]
        public void RwsExceptionHandler_raises_exception_for_401_responses_with_html()
        {

            var content = new StringContent(@"<h2>HTTP Error 401.0 - Unauthorized</h2>");

            var responseMessage401 = new HttpResponseMessage
            {
                Content = content,
                StatusCode = System.Net.HttpStatusCode.Unauthorized
            };

            try
            {
                RwsExceptionHandler.Parse(responseMessage401);
            }
            catch (RwsException ex)
            {
                Assert.AreEqual("Unauthorized.", ex.Message);
            }

        }

        [TestMethod]
        public void RwsExceptionHandler_raises_exception_for_unexpected_status_codes()
        {

            var content = new StringContent(@"Whoops, something is wrong.");

            var responseMessage410 = new HttpResponseMessage
            {
                Content = content,
                StatusCode = System.Net.HttpStatusCode.Gone
            };

            try
            {
                RwsExceptionHandler.Parse(responseMessage410);
            }
            catch (RwsException ex)
            {
                Assert.AreEqual("Unexpected Status Code (410)", ex.Message);
            }

        }




        [TestMethod]
        public void RwsExceptionHandler_attaches_a_RwsPostErrorResponse_for_POST_requests()
        {

            var content = new StringContent(@"<Response
                                            ReferenceNumber=""0b47fe86-542f-4070-9e7d-16396a5ef08a""
                                            InboundODMFileOID=""Not Supplied""
                                            IsTransactionSuccessful=""0""
                                            ReasonCode=""RWS00024""
                                            ErrorOriginLocation=""/ODM/ClinicalData[1]/SubjectData[1]""
                                            SuccessStatistics=""Rave objects touched: Subjects=0; Folders=0; Forms=0; Fields=0; LogLines=0""
                                            ErrorClientResponseMessage=""Subject already exists."">
                                            </Response>", Encoding.UTF8, "text/xml");

            var responseMessage400 = new HttpResponseMessage
            {
                Content = content,
                StatusCode = System.Net.HttpStatusCode.BadRequest,
                RequestMessage = new  HttpRequestMessage 
                {
                    Method = HttpMethod.Post   
                }
            };

            try
            {
                RwsExceptionHandler.Parse(responseMessage400);
            }
            catch (RwsException ex)
            {
                Assert.IsInstanceOfType(ex.ErrorResponse, typeof(RwsPostErrorResponse));
            }

        }

    }
}
