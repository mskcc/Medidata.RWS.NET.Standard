using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Flurl.Http.Testing;
using Medidata.RWS.NET.Standard.Core;
using Medidata.RWS.NET.Standard.Core.Objects;
using Medidata.RWS.NET.Standard.Core.Requests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Medidata.RWS.NET.Standard.Tests.Core.Requests
{
    [TestClass]
    public class StudyVersionRequestTest
    {
        
        [TestMethod]
        public void StudyVersionRequest_can_properly_construct_a_url()
        {
            var request = new StudyVersionRequest("Mediflex(Dev)", Oid: "1234");

            Assert.AreEqual("metadata/studies/Mediflex(Dev)/versions/1234", request.UrlPath());

            Assert.AreEqual(1234, request.Oid);
 
        }


    }
}
