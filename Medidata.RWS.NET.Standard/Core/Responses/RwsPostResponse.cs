using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Medidata.RWS.NET.Standard.Core.Responses
{
    public class RwsPostResponse : RwsResponse
    {
        public string SubjectNumberInStudySite { get; }

        public string DraftImported { get; }

        public string SubjectNumberInStudy { get; }

        public RwsPostResponse(HttpResponseMessage response) : base(response)
        {

            DraftImported = RootElement?.Attribute("DraftImported")?.Value;
            SubjectNumberInStudy = RootElement?.Attribute("SubjectNumberInStudy")?.Value;
            SubjectNumberInStudySite = RootElement?.Attribute("SubjectNumberInStudySite")?.Value;

        }
    }
}
