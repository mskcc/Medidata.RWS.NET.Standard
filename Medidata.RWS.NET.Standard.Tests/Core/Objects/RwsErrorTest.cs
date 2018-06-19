using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl.Http.Testing;
using Medidata.RWS.NET.Standard.Core;
using Medidata.RWS.NET.Standard.Core.Objects;
using Medidata.RWS.NET.Standard.Core.Requests;
using Medidata.RWS.NET.Standard.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Medidata.RWS.NET.Standard.Tests.Core.Objects
{
    [TestClass]
    public class RwsErrorTest
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
        public async Task RwsError_can_derive_ErrorDescription()
        {
            _httpTest.RespondWith(
                @"<?xml version=""1.0"" encoding=""utf-8""?>
                    <ODM xmlns:mdsol=""http://www.mdsol.com/ns/odm/metadata""
                         FileType=""Snapshot""
                         CreationDateTime=""2013-04-08T10:28:49.578-00:00""
                         FileOID=""4d13722a-ceb6-4419-a917-b6ad5d0bc30e""
                         ODMVersion=""1.3""
                         mdsol:ErrorDescription=""Incorrect login and password combination. [RWS00008]""
                         xmlns=""http://www.cdisc.org/ns/odm/v1.3"" />", 401)
                     .Settings.AfterCall = call => {

                         call.Response.Content.Headers.ContentType.MediaType = "text/xml";
                       
                    };

            var rwsConnection = new RwsConnection("innovate", "test", "password");

            try
            {
                var response = await rwsConnection.SendRequestAsync(new PostDataRequest("test"));
            } catch( RwsException ex)
            {
                Assert.AreEqual("Incorrect login and password combination. [RWS00008]", ex.Message);
            }


        }
    }
}
