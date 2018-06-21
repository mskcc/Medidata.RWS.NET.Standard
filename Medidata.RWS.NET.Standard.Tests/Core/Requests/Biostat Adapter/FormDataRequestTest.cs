using System;
using Medidata.RWS.NET.Standard.Core.Requests.BiostatAdapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Medidata.RWS.NET.Standard.Tests.Core.Requests.BiostatAdapter
{
    [TestClass]
    public class FormDataRequestTest
    {
        [TestMethod]
        public void FormDataRequest_constructs_the_correct_UrlPath_for_forms()
        {

            var req = new FormDataRequest("Mediflex", "DEV", "csv", "DM");

            Assert.AreEqual("studies/Mediflex(DEV)/datasets/DM.csv", req.UrlPath());

            var req2 = new FormDataRequest("Mediflex", "DEV", "xml", "DM");

            Assert.AreEqual("studies/Mediflex(DEV)/datasets/DM", req2.UrlPath());

        }
    }
}
