using System;
using System.Collections.Generic;
using System.Text;
using Medidata.RWS.NET.Standard.Helpers;
using Medidata.RWS.NET.Standard.ODM;

namespace Medidata.RWS.NET.Standard.Core.Objects
{
    public class RwsStudyListItem
    {

        /// <summary>
        /// The oid
        /// </summary>
        public readonly string Oid;
        /// <summary>
        /// The study name
        /// </summary>
        public readonly string StudyName;
        /// <summary>
        /// The protocol name
        /// </summary>
        public readonly string ProtocolName;
        /// <summary>
        /// The environment
        /// </summary>
        public readonly string Environment;
        /// <summary>
        /// The project type
        /// </summary>
        public readonly string ProjectType;


        public RwsStudyListItem(Study study)
        {
            Oid = study.OID;
            StudyName = study.GlobalVariables.StudyName.Value;
            ProtocolName = study.GlobalVariables.ProtocolName.Value;
            ProjectType = study.ProjectType;
            Environment = RwsHelpers.Strings.GetEnvironmentFromStudyNameAndProtocol(StudyName, ProtocolName);
        }

        /// <summary>
        /// Whether or not this study is a production study.
        /// </summary>
        public bool IsProduction => Environment == "" && ProjectType != "GlobalLibraryVolume";

    }
}
