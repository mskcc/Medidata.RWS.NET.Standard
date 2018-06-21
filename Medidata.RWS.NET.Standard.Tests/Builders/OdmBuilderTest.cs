using System;
using System.Linq;
using System.Xml.Linq;
using Medidata.RWS.NET.Standard.Builders;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Medidata.RWS.NET.Standard.Tests.Builders
{
	[TestClass]
    public class OdmBuilderTest
    {

        private OdmBuilder builder;

        [TestInitialize]
        public void Setup()
        {
            builder = new OdmBuilder()
                .WithClinicalData(
                    "Test(Dev)", cd => cd.WithSubjectData(
                        "Subj001", "101", sd => sd.AddStudyEventData(
                            "Folder01", sed => sed.AddFormData(
                                "Form01", fd => fd
                                .AddItemGroupData(
                                    "LogLine01", ig => ig
                                    .AddItemData("Item01", "Value", id => id.Build())
                                    .AddItemData("Item02", "Value2", id => id.Build()))
                                .AddItemGroupData(
                                    "LogLine02", ig => ig
                                    .AddItemData("Item03", "Value3", id => id.Build())
                                    .AddItemData("Item04", "Value4", id => id.Build()))
                            ))));
        }


        [TestMethod]
        public void OdmBuilder_can_construct_ODM_classes()
        {
          
            Assert.IsInstanceOfType(builder.Build(), typeof(ODM.ODM));

        }

        [TestMethod]
        public void OdmBuilder_can_construct_ODM_with_nested_props()
        {

            var _odm = builder.Build();

            Assert.IsNotNull(_odm.FileOID);

            Assert.AreEqual("Test(Dev)", _odm.ClinicalData.First().StudyOID);

        }


        [TestMethod]
        public void OdmBuilder_can_produce_an_XDocument()
        {
         
            Assert.IsInstanceOfType(builder.AsXDocument(), typeof(XDocument)) ;
            
        }


        [TestMethod]
        public void OdmBuilder_can_produce_an_XML_string_that_can_be_parsed()
        {

            var xmlString = builder.AsXMLString();
            Assert.IsInstanceOfType(xmlString, typeof(string));
            var xDoc = XDocument.Parse(xmlString);
            Assert.IsTrue(xDoc.Root.GetDefaultNamespace().ToString()
                          .Contains("http://www.cdisc.org/ns/odm"));


        }

    }
}
