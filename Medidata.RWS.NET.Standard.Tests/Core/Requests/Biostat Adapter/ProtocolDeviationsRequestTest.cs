using System;
using Flurl;
using Medidata.RWS.NET.Standard.Core.Requests.BiostatAdapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Medidata.RWS.NET.Standard.Tests.Core.Requests.BiostatAdapter
{
    [TestClass]
    public class ProtocolDeviationsRequestTest
    {
        [TestMethod]
        public void ProtocolDeviationsRequest_can_create_proper_url()
        {
            var req = new ProtocolDeviationsRequest("Mediflex", "Dev");

            Assert.AreEqual($"datasets/SDTMProtocolDeviations.csv?studyid={Url.Encode("Mediflex(Dev)")}", req.UrlPath());

            var req2 = new ProtocolDeviationsRequest("Mediflex", "Dev", "xml");

            Assert.AreEqual($"datasets/SDTMProtocolDeviations?studyid={Url.Encode("Mediflex(Dev)")}", req2.UrlPath());
        }
    }
}
