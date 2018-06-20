using System;
using Flurl;
using Medidata.RWS.NET.Standard.Core.Requests.BiostatAdapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Medidata.RWS.NET.Standard.Tests.Core.Requests.BiostatAdapter
{
    [TestClass]
    public class CommentDataRequestTest
    {
        [TestMethod]
        public void CommentDataRequest_can_create_proper_url()
        {
            var req = new CommentDataRequest("Mediflex", "Dev");

            Assert.AreEqual($"datasets/SDTMComments.csv?studyid={Url.Encode("Mediflex(Dev)")}", req.UrlPath());

            var req2 = new CommentDataRequest("Mediflex", "Dev", "xml");

            Assert.AreEqual($"datasets/SDTMComments?studyid={Url.Encode("Mediflex(Dev)")}", req2.UrlPath());
        }
    }
}
