using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Medidata.RWS.NET.Standard.Core.Requests.ODMAdapter;
using Flurl;

namespace Medidata.RWS.NET.Standard.Tests.Core.Requests.ODMAdapter
{

    [TestClass]
    public class VersionFoldersRequestTests
    {
        [TestMethod]
        public void VersionFoldersRequest_can_properly_create_a_request_with_query_string_parameters()
        {

            var vfReq = new VersionFoldersRequest(ProjectName: "Mediflex", Environment: "Dev");

            Assert.IsTrue(vfReq.UrlPath().Contains("datasets/VersionFolders.odm"));

            Assert.IsTrue(vfReq.UrlPath().Contains(string.Format("studyoid={0}", Url.Encode(vfReq.studyoid))));

        }
    }
}
