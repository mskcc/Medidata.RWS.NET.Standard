using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl.Http.Testing;
using Medidata.RWS.NET.Standard.Core;
using Medidata.RWS.NET.Standard.Core.Requests;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Medidata.RWS.NET.Standard.Tests.Http
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
        public async Task it_can_get_details_about_the_last_result()
        {
            var RwsConnection = new RwsConnection("innovate", "test", "password");

            var rwsResponse = await RwsConnection.SendRequestAsync(new FakeRwsRequest(HttpMethod.Get));

            Assert.IsNotNull(RwsConnection.LastResult);
            Assert.AreEqual(HttpStatusCode.OK, RwsConnection.LastResult.StatusCode);

        }



    }
}
