using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Medidata.RWS.NET.Standard.Helpers
{
    public static class RwsHelpers
    {
        public static class Xml
        {

            // filters control characters but allows only properly-formed surrogate sequences
            private static readonly Regex InvalidXmlChars = new Regex(
                @"(?<![\uD800-\uDBFF])[\uDC00-\uDFFF]|[\uD800-\uDBFF](?![\uDC00-\uDFFF])|[\x00-\x08\x0B\x0C\x0E-\x1F\x7F-\x9F\uFEFF\uFFFE\uFFFF\u200B]",
                RegexOptions.Compiled);

            private static readonly char[] ByteOrderMark = { '\uFEFF', '\u200B' };

            /// <summary>
            /// removes any unusual Unicode characters that can't be encoded into XML
            /// </summary>
            public static string Sanitize(string text)
            {
                return string.IsNullOrEmpty(text) ? "" : InvalidXmlChars.Replace(text, "");
            }


            /// <summary>
            /// Parse a string representation of a RWS XML Response.
            /// </summary>
            /// <param name="xmlString"></param>
            /// <returns>XmlElement</returns>
            public static XDocument GetXDocumentFromString(string xmlString)
            {
                //xmlString = Sanitize(xmlString);

                XDocument xmlDoc = new XDocument();

                if (string.IsNullOrEmpty(xmlString))
                {
                    return xmlDoc;
                }

                using (XmlReader reader = XmlReader.Create(new StringReader(xmlString), new XmlReaderSettings { CheckCharacters = false, DtdProcessing = DtdProcessing.Parse }))
                {
                    while (reader.Read())
                    {
                        xmlDoc = XDocument.Load(reader);
                    }
                }

                return xmlDoc;

            }


            /// <summary>
            /// Deserialize a strongly typed object from an XML string.
            /// </summary>
            /// <typeparam name="T"></typeparam>
            /// <param name="xmlString"></param>
            /// <returns></returns>
            public static T DeserializeFromString<T>(string xmlString)
            {
                return (T)DeserializeFromString(xmlString, typeof(T));
            }


            /// <summary>
            /// Deserialize a generic object from an XML string.
            /// </summary>
            /// <param name="objectData"></param>
            /// <param name="type"></param>
            /// <returns></returns>
            private static object DeserializeFromString(string objectData, Type type)
            {
                //remove the first ByteOrderMark (BOM) if it exists
                //see http://stackoverflow.com/questions/1317700/strip-byte-order-mark-from-string-in-c-sharp
                objectData = objectData.Trim(ByteOrderMark);

                var serializer = new XmlSerializer(type);
                object result;

                using (TextReader reader = new StringReader(objectData))
                {
                    result = serializer.Deserialize(reader);
                }

                return result;
            }

        }

        public static class Strings
        {

            /// <summary>
            /// Return the environment name based on a study and protocol name.
            /// </summary>
            /// <param name="studyName"></param>
            /// <param name="protocolName"></param>
            /// <returns></returns>
            public static string GetEnvironmentFromStudyNameAndProtocol(string studyName, string protocolName)
            {

                var rawEnvironment = studyName.Substring(protocolName.Length).Trim();
                if (!rawEnvironment.Contains("(")) return rawEnvironment;
                var lBracePos = rawEnvironment.IndexOf("(", StringComparison.Ordinal);
                var rBracePos = rawEnvironment.IndexOf(")", StringComparison.Ordinal);
                return rawEnvironment.Substring(lBracePos + 1, rBracePos - 1);

            }



            /// <summary>
            /// Gets the environment name from a study oid.
            /// </summary>
            /// <param name="studyOid">The study oid.</param>
            /// <returns></returns>
            public static string GetEnvironmentNameFromStudyOid(string studyOid)
            {
                if (!studyOid.EndsWith(")") || !studyOid.Contains("(")) return string.Empty;
                var lBracePos = studyOid.IndexOf("(", StringComparison.Ordinal);
                var rBracePos = studyOid.IndexOf(")", StringComparison.Ordinal);
                return studyOid.Substring(lBracePos + 1, (rBracePos - 1) - lBracePos).Trim();

            }


            /// <summary>
            /// Gets the project name from study oid.
            /// </summary>
            /// <param name="studyOid">The study oid.</param>
            /// <returns></returns>
            public static string GetProjectNameFromStudyOid(string studyOid)
            {
                if (!studyOid.EndsWith(")") || !studyOid.Contains("(")) return studyOid.Trim();
                var lBracePos = studyOid.IndexOf("(", StringComparison.Ordinal);
                return studyOid.Substring(0, lBracePos).Trim();

            }

        }


    }

}
