using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl.Http.Testing;
using Medidata.RWS.NET.Standard.Core;
using Medidata.RWS.NET.Standard.Core.Objects;
using Medidata.RWS.NET.Standard.Core.Requests;
using Medidata.RWS.NET.Standard.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Medidata.RWS.NET.Standard.Tests.Core.Objects
{
    [TestClass]
    public class RwsErrorTest
    {

        [TestMethod]
        public void RwsError_has_an_ErrorDescription()
        {
            var error = new RwsError(new HttpResponseMessage{
                Content = new StringContent(@"<?xml version=""1.0"" encoding=""utf-8""?>
                    <ODM xmlns:mdsol=""http://www.mdsol.com/ns/odm/metadata""
                         FileType=""Snapshot""
                         CreationDateTime=""2013-04-08T10:28:49.578-00:00""
                         FileOID=""4d13722a-ceb6-4419-a917-b6ad5d0bc30e""
                         ODMVersion=""1.3""
                         mdsol:ErrorDescription=""Incorrect login and password combination. [RWS00008]""
                         xmlns=""http://www.cdisc.org/ns/odm/v1.3"" />", Encoding.UTF8, "text/xml")
            });

            Assert.AreEqual("Incorrect login and password combination. [RWS00008]", error.GetErrorDescription());


        }



    }
}
