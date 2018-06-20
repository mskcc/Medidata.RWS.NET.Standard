using System;
using Medidata.RWS.NET.Standard.Core.Requests.BiostatAdapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Medidata.RWS.NET.Standard.Tests.Core.Requests.BiostatAdapter
{
    [TestClass]
    public class ProjectMetadataRequestTest
    {
        [TestMethod]
        public void ProjectMetadataRequest_can_create_proper_url()
        {
            var req = new ProjectMetadataRequest("Mediflex");

            Assert.AreEqual("datasets/ClinicalViewMetadata.csv?ProjectName=Mediflex", req.UrlPath());

            var req2 = new ProjectMetadataRequest("Mediflex", "xml");

            Assert.AreEqual("datasets/ClinicalViewMetadata?ProjectName=Mediflex", req2.UrlPath());
        }
    }
}
