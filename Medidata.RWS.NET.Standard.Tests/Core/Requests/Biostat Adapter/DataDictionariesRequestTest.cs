using System;
using Flurl;
using Medidata.RWS.NET.Standard.Core.Requests.BiostatAdapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Medidata.RWS.NET.Standard.Tests.Core.Requests.BiostatAdapter
{
    [TestClass]
    public class DataDictionariesRequestTest
    {
        [TestMethod]
        public void DataDictionariesRequest_constructs_the_correct_UrlPath()
        {

            var req = new DataDictionariesRequest("Mediflex", "DEV");

            Assert.AreEqual(req.UrlPath(), "datasets/SDTMDataDictionaries.csv?studyid=Mediflex(DEV)");

            var req2 = new DataDictionariesRequest("Mediflex", "DEV", datasetFormat: "xml");

            Assert.AreEqual(req2.UrlPath(), "datasets/SDTMDataDictionaries?studyid=Mediflex(DEV)");

        }
    }
}
