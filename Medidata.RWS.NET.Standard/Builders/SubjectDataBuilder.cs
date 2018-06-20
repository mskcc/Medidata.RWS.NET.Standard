using System;
using Medidata.RWS.NET.Standard.ODM;

namespace Medidata.RWS.NET.Standard.Builders
{
    public class SubjectDataBuilder
    {
        private string subjectKey;
        private string locationOID;

        public SubjectDataBuilder(string subjectKey, string locationOID)
        {
            this.subjectKey = subjectKey;
            this.locationOID = locationOID;
        }

        internal SubjectData Build()
        {
            throw new NotImplementedException();
        }
    }
}