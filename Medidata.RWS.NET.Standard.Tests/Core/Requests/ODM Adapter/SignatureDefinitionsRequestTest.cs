using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Medidata.RWS.NET.Standard.Core.Requests.ODMAdapter;
using Flurl;

namespace Medidata.RWS.NET.Standard.Tests.Core.Requests.ODMAdapter
{

    [TestClass]
    public class SignatureDefinitionsRequestTest
    {
        [TestMethod]
        public void SignatureDefinitionsRequest_can_properly_create_a_request_with_query_string_parameters()
        {

            var sigReq = new SignatureDefinitionsRequest(ProjectName: "MediFlex(DEV)");

            Assert.AreEqual(string.Format("datasets/Signatures.odm?studyid={0}", Url.Encode(sigReq.ProjectName.Trim())), sigReq.UrlPath());

        }
    }
}
