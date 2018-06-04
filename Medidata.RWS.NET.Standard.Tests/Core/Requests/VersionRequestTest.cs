using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl.Http.Testing;
using Medidata.RWS.NET.Standard.Core;
using Medidata.RWS.NET.Standard.Core.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Medidata.RWS.NET.Standard.Tests.Core.Requests
{
    [TestClass]
    public class VersionRequestTest
    {
        [TestMethod]
        public void VersionRequest_can_properly_construct_a_url()
        {
            var request = new VersionRequest();

            Assert.AreEqual("version", request.UrlPath());

        }

    }
}
