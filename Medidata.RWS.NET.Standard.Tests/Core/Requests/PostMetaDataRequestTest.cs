using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Flurl.Http.Testing;
using Medidata.RWS.NET.Standard.Core;
using Medidata.RWS.NET.Standard.Core.Objects;
using Medidata.RWS.NET.Standard.Core.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Medidata.RWS.NET.Standard.Tests.Core.Requests
{
    [TestClass]
    public class PostMetaDataRequestTest
    {
        
        [TestMethod]
        public void PostMetaDataRequestTest_can_properly_construct_a_url()
        {
            var request = new PostMetadataRequest("Mediflex(Dev)", "test data");

            Assert.AreEqual("metadata/studies/Mediflex(Dev)/drafts", request.UrlPath());

            Assert.IsTrue(request.Headers.TryGetValue("Content-type", out var contentType));

            Assert.AreEqual(contentType, "text/xml");

        }


    }
}
