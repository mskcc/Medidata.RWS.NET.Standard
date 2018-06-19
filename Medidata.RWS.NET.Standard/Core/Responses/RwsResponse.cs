using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Xml.Linq;
using Medidata.RWS.NET.Standard.Helpers;

namespace Medidata.RWS.NET.Standard.Core.Responses
{
    public class RwsResponse : RwsXmlResponse, IRwsResponse
    {
        public RwsResponse(HttpResponseMessage response) : base(response)
        {
            SubjectsTouched = 0;
            FoldersTouched = 0;
            FormsTouched = 0;
            FieldsTouched = 0;
            LogLinesTouched = 0;

            SuccessStatistics = RootElement?.Attribute("SuccessStatistics")?.Value;

            if (SuccessStatistics != null && SuccessStatistics.StartsWith("Rave objects touched:", StringComparison.CurrentCulture))
            {
                SuccessStatistics = SuccessStatistics.Substring("Rave objects touched:".Length + 1);

                var parts = SuccessStatistics.Split(';');

                foreach (var part in parts)
                {
                    var nameValues = part.Trim().Split('=');

                    var name = nameValues.ElementAt(0);
                    var value = nameValues.ElementAt(1);

                    switch (name)
                    {
                        case "Subjects":
                            SubjectsTouched = Convert.ToInt32(value);
                            break;
                        case "Folders":
                            FoldersTouched = Convert.ToInt32(value);
                            break;
                        case "Forms":
                            FormsTouched = Convert.ToInt32(value);
                            break;
                        case "Fields":
                            FieldsTouched = Convert.ToInt32(value);
                            break;
                        case "LogLines":
                            LogLinesTouched = Convert.ToInt32(value);
                            break;
                        default:
                            throw new KeyNotFoundException($"Unknown RAVE Object {name} in response {SuccessStatistics}");
                    }

                }

            }

            NewRecords = RootElement?.Attribute("NewRecords")?.Value;
        }

        /// <summary>
        /// The subjects touched
        /// </summary>
        public readonly int SubjectsTouched;
        /// <summary>
        /// The fields touched
        /// </summary>
        public readonly int FieldsTouched;
        /// <summary>
        /// The folders touched
        /// </summary>
        public readonly int FoldersTouched;
        /// <summary>
        /// The forms touched
        /// </summary>
        public readonly int FormsTouched;
   
        /// <summary>
        /// The log lines touched
        /// </summary>
        public readonly int LogLinesTouched;
        /// <summary>
        /// The new records
        /// </summary>
        public readonly string NewRecords;

        /// <summary>
        /// The success stats
        /// </summary>
        public readonly string SuccessStatistics;


    }
}
