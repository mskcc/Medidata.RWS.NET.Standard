using System;
using Medidata.RWS.NET.Standard.Core.Requests.BiostatAdapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Medidata.RWS.NET.Standard.Tests.Core.Requests.BiostatAdapter
{
    [TestClass]
    public class ViewMetadataRequestTest
    {
        [TestMethod]
        public void ViewMetadataRequest_can_create_proper_url()
        {
            var req = new ViewMetadataRequest("DM");

            Assert.AreEqual("datasets/ClinicalViewMetadata.csv?ViewName=DM", req.UrlPath());

            var req2 = new ViewMetadataRequest("DM", "xml");

            Assert.AreEqual("datasets/ClinicalViewMetadata?ViewName=DM", req2.UrlPath());
        }
    }
}
