using Flurl;

namespace Medidata.RWS.NET.Standard.Core.Requests
{
    public class StudyVersionRequest : VersionRequestBase
    {

        public StudyVersionRequest(string projectName, string Oid) : base(projectName, Oid)
        {
        }

        public override string UrlPath()
        {
            return Url.Combine("metadata", "studies", ProjectName, "versions", Oid.ToString());
        }
    }
}