using System;
namespace Medidata.RWS.NET.Standard.Core.Requests
{
    public abstract class VersionRequestBase : RwsAuthorizedGetRequest
    {
        public string ProjectName { get; }
        private readonly string _Oid;

        public VersionRequestBase(string projectName, string Oid)
        {
            this._Oid = Oid;
            ProjectName = projectName;
        }

        public int Oid { get { return int.Parse(_Oid); }}
    }
}
