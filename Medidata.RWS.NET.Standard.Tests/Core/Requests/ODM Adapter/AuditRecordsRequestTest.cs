using System;
using Flurl;
using Medidata.RWS.NET.Standard.Core.Requests.ODMAdapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Medidata.RWS.NET.Standard.Tests.Core.Requests.ODMAdapter
{
    [TestClass]
    public class AuditRecordsRequestTest
    {
        [TestMethod]
        public void AuditRecordsRequest_can_properly_create_a_request_with_query_string_parameters()
        {

            var aRequest = new AuditRecordsRequest(ProjectName: "MediFlex", Environment: "Dev", startid: 1, per_page: 100);

            Assert.IsTrue(aRequest.UrlPath().Contains("datasets/ClinicalAuditRecords.odm"));

            Assert.IsTrue(aRequest.UrlPath().Contains(string.Format("studyoid={0}", Url.Encode(aRequest.studyoid))));

            Assert.IsTrue(aRequest.UrlPath().Contains("startid=1"));

            Assert.IsTrue(aRequest.UrlPath().Contains("per_page=100"));

            aRequest = new AuditRecordsRequest(ProjectName: "MediFlex", Environment: "Dev", startid: 2596, per_page: 45);

            Assert.IsTrue(aRequest.UrlPath().Contains("startid=2596"));

            Assert.IsTrue(aRequest.UrlPath().Contains("per_page=45"));
        }
    }
}
