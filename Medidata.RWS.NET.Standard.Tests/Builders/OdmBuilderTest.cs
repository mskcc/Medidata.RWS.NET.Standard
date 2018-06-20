using System;
using System.Linq;
using Medidata.RWS.NET.Standard.Builders;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Medidata.RWS.NET.Standard.Tests.Builders
{
	[TestClass]
    public class OdmBuilderTest
    {
        [TestMethod]
        public void OdmBuilder_can_construct_ODM_classes()
        {
            var builder = new OdmBuilder();
            Assert.IsInstanceOfType(builder.Build(), typeof(ODM.ODM));

        }

        [TestMethod]
        public void OdmBuilder_can_construct_ODM_with_nested_props()
        {
            var builder = new OdmBuilder();

            var odm = builder.WithClinicalData("Test(Dev)", cd => cd.Build()).Build();

            Assert.AreEqual("Test(Dev)", odm.ClinicalData.First().StudyOID);

        }

    }
}
