using System;
using Medidata.RWS.NET.Standard.Core.Requests.BiostatAdapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Medidata.RWS.NET.Standard.Tests.Core.Requests.BiostatAdapter
{
    [TestClass]
    public class ClinicalViewMetaDataRequestTests
    {
        [TestMethod]
        public void ClinicalViewMetaDataRequest_creates_proper_request_object()
        {

            var req = new ClinicalViewMetaDataRequest("FakeitTilyaMakeit", "DEV");

            Assert.AreEqual("FakeitTilyaMakeit(DEV)", req.StudyNameAndEnvironment());
            Assert.AreEqual("studies/FakeitTilyaMakeit(DEV)/datasets/metadata/regular", req.UrlPath());

        }
    }
}
