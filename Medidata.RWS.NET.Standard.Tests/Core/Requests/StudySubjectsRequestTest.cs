using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Flurl.Http.Testing;
using Medidata.RWS.NET.Standard.Core;
using Medidata.RWS.NET.Standard.Core.Objects;
using Medidata.RWS.NET.Standard.Core.Requests;
using Medidata.RWS.NET.Standard.Core.Responses;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Medidata.RWS.NET.Standard.Tests.Core.Requests
{
    [TestClass]
    public class StudySubjectsRequestTests
    {

        string ProjectName = "A Project";
        string Environment = "DEV";

        [TestInitialize]
        public void SetUp()
        {

        }

        [TestMethod]
        public void StudySubjectsRequest_validates_subject_key_type()
        {
            try
            {
                var request = new StudySubjectsRequest(ProjectName, Environment, subjectKeyType: "BetaMax");
            }
            catch (NotSupportedException ex)
            {
                Assert.AreEqual(ex.Message, "SubjectKeyType BetaMax is not a valid value");
            }

            var request2 = new StudySubjectsRequest(ProjectName, Environment, subjectKeyType: "SubjectName");
            Assert.AreEqual(ProjectName, request2.ProjectName);

        }



        [TestMethod]
        public void StudySubjectsRequest_can_request_with_UUID()
        {

            var request = new StudySubjectsRequest(ProjectName, Environment, subjectKeyType: "SubjectUUID");
            Assert.IsTrue(request.UrlPath().Contains("subjectKeyType=SubjectUUID"));

        }


        [TestMethod]
        public void StudySubjectsRequest_can_omit_subject_key_type()
        {

            var request = new StudySubjectsRequest(ProjectName, Environment);
            Assert.IsFalse(request.UrlPath().Contains("subjectKeyType"));

        }


        [TestMethod]
        public void StudySubjectsRequest_can_request_status()
        {
            var request = new StudySubjectsRequest(ProjectName, Environment, status: true);

            Assert.IsTrue(request.UrlPath().Contains("status=all"));

        }


        [TestMethod]
        public void StudySubjectsRequest_correctly_requests_with_include_parameter_when_provided()
        {
            StudySubjectsRequest request;
            request = new StudySubjectsRequest(ProjectName, Environment, include: "inactive");
            Assert.IsTrue(request.UrlPath().Contains("include=inactive"));
            request = new StudySubjectsRequest(ProjectName, Environment, include: "inactiveAndDeleted");
            Assert.IsTrue(request.UrlPath().Contains("include=inactiveAndDeleted"));
            request = new StudySubjectsRequest(ProjectName, Environment, include: "deleted");
            Assert.IsTrue(request.UrlPath().Contains("include=deleted"));

            try
            {
                request = new StudySubjectsRequest(ProjectName, Environment, include: "All_da_things");
            }
            catch (NotSupportedException ex)
            {
                Assert.AreEqual(ex.Message, "If provided, `include` must be one of the following: inactive,deleted,inactiveAndDeleted");
            }

        }


        [TestMethod]
        public async Task StudySubjectsRequest_correctly_parses_response()
        {
            var httpTest = new HttpTest();

            httpTest.RespondWith(
                @"<ODM FileType=""Snapshot"" FileOID=""767a1f8b-7b72-4d12-adbe-37d4d62ba75e""
                         CreationDateTime=""2013-04-08T10:02:17.781-00:00""
                         ODMVersion=""1.3""
                         xmlns:mdsol=""http://www.mdsol.com/ns/odm/metadata""
                         xmlns:xlink=""http://www.w3.org/1999/xlink""
                         xmlns=""http://www.cdisc.org/ns/odm/v1.3"">
                 <ClinicalData StudyOID=""FakeItTillYaMakeIt(Dev)"" MetaDataVersionOID=""1111"">
                    <SubjectData SubjectKey=""000002"">
                       <SiteRef LocationOID=""101""/>
                    </SubjectData>
                 </ClinicalData>
                 <ClinicalData StudyOID=""FakeItTillYaMakeIt(Dev)"" MetaDataVersionOID=""1111"">
                     <SubjectData SubjectKey=""000003"">
                        <SiteRef LocationOID=""6""/>
                     </SubjectData>
                 </ClinicalData>
                 <ClinicalData StudyOID=""FakeItTillYaMakeIt(Dev)"" MetaDataVersionOID=""1111"">
                     <SubjectData SubjectKey=""EC82F1AB-D463-4930-841D-36FC865E63B2"" mdsol:SubjectName=""1"" mdsol:SubjectKeyType=""SubjectUUID"">
                        <SiteRef LocationOID=""6""/>
                     </SubjectData>
                 </ClinicalData>
            </ODM>");

            var connection = new RwsConnection("innovate", "test", "pw");
            var request = new StudySubjectsRequest(ProjectName, Environment);
            var response = await connection.SendRequestAsync(request) as RwsSubjects;

            Assert.IsInstanceOfType(response, typeof(RwsSubjects));

            var subjectNames = new string[] { "000002", "000003", "1" };

            foreach (var subject in response)
            {
                Assert.IsInstanceOfType(subject, typeof(RwsSubjectListItem));
                Assert.IsTrue(subjectNames.Contains(subject.SubjectName));
            }

            httpTest.Dispose();


        }


    }
}
