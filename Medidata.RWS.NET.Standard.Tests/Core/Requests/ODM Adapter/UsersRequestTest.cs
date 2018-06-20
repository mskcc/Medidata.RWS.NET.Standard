using System;
using Flurl;
using Medidata.RWS.NET.Standard.Core.Requests.ODMAdapter;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Medidata.RWS.NET.Standard.Tests.Core.Requests.ODMAdapter
{
    [TestClass]
    public class UsersRequestTests
    {
        [TestMethod]
        public void UsersRequest_can_properly_create_a_request_with_query_string_parameters()
        {

            var uRequest = new UsersRequest(ProjectName: "Mediflex", Environment: "Dev", locationoid: "101");

            Assert.IsTrue(uRequest.UrlPath().Contains("datasets/Users.odm"));

            Assert.IsTrue(uRequest.UrlPath().Contains(string.Format("studyoid={0}", Url.Encode(uRequest.studyoid))));

            Assert.IsTrue(uRequest.UrlPath().Contains(string.Format("locationoid={0}", Url.Encode(uRequest.locationoid))));
        }
    }
}
