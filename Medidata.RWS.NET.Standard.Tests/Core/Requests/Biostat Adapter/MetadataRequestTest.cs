using System;
using Medidata.RWS.NET.Standard.Core.Requests.BiostatAdapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Medidata.RWS.NET.Standard.Tests.Core.Requests.BiostatAdapter
{
    [TestClass]
    public class MetadataRequestTest
    {
        [TestMethod]
        public void MetadataRequest_can_create_proper_url()
        {
            var req = new MetadataRequest();

            Assert.AreEqual("datasets/ClinicalViewMetadata.csv", req.UrlPath());

            var req2 = new MetadataRequest("xml");

            Assert.AreEqual("datasets/ClinicalViewMetadata", req2.UrlPath());
        }
    }
}
