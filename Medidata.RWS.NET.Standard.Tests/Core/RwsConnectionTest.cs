using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl.Http.Testing;
using Medidata.RWS.NET.Standard.Core;
using Medidata.RWS.NET.Standard.Core.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Medidata.RWS.NET.Standard.Tests.Core
{
    [TestClass]
    public class RwsConnectionTest
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
        public async Task RwsConnection_can_get_details_about_the_last_result()
        {
            var rwsConnection = new RwsConnection("innovate", "test", "password");

            await rwsConnection.SendRequestAsync(new FakeRwsRequest());

            Assert.IsNotNull(rwsConnection.LastResult);
            Assert.AreEqual(HttpStatusCode.OK, rwsConnection.LastResult.StatusCode);

        }


        [TestMethod]
        public async Task RwsConnection_can_get_details_about_the_request_time()
        {
            var rwsConnection = new RwsConnection("innovate", "test", "password");

            await rwsConnection.SendRequestAsync(new FakeRwsRequest());

            Assert.IsNotNull(rwsConnection.RequestTime);

        }

        [TestMethod]
        public async Task RwsConnection_can_build_the_proper_URL_from_a_request()
        {
            var rwsConnection = new RwsConnection("innovate", "test", "password");

            await rwsConnection.SendRequestAsync(new FakeRwsRequest());

            Assert.AreEqual(
                "https://innovate.mdsol.com/RaveWebServices/fakepath", 
                rwsConnection.LastResult.RequestMessage.RequestUri.AbsoluteUri
            );

        }



    }
}
