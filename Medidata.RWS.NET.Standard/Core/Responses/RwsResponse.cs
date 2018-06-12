using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Xml.Linq;
using Medidata.RWS.NET.Standard.Helpers;

namespace Medidata.RWS.NET.Standard.Core.Responses
{
    public class RwsResponse : IRwsResponse
    {
        public RwsResponse(HttpResponseMessage response)
        {
            ResponseObject = response;
            ReferenceNumber = RootElement?.Attribute("ReferenceNumber")?.Value;
            InboundODMFileOID = RootElement?.Attribute("InboundODMFileOID")?.Value;
            IsTransactionSuccessful = RootElement?.Attribute("IsTransactionSuccessful")?.Value == "1";

            SubjectsTouched = 0;
            FoldersTouched = 0;
            FormsTouched = 0;
            FieldsTouched = 0;
            LogLinesTouched = 0;

            SuccessStatistics = RootElement?.Attribute("SuccessStatistics")?.Value;

            if (SuccessStatistics != null && SuccessStatistics.StartsWith("Rave objects touched:"))
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

        public HttpResponseMessage ResponseObject { get; }

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
        /// The inbound odm file oid
        /// </summary>
        public readonly string InboundODMFileOID;
        /// <summary>
        /// Whether or not the transaction is successful.
        /// </summary>
        public readonly bool IsTransactionSuccessful;
        /// <summary>
        /// The log lines touched
        /// </summary>
        public readonly int LogLinesTouched;
        /// <summary>
        /// The new records
        /// </summary>
        public readonly string NewRecords;
        /// <summary>
        /// The reference number
        /// </summary>
        public readonly string ReferenceNumber;
        /// <summary>
        /// The success stats
        /// </summary>
        public readonly string SuccessStatistics;


        public XElement RootElement => XmlDocument.Root;

        public XDocument XmlDocument => RwsHelpers.Xml.GetXDocumentFromString(ResponseObject.Content.ReadAsStringAsync().Result);
    }
}
