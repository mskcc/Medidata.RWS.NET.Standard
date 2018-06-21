using System;
using System.Net.Http;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using Medidata.RWS.NET.Standard.Helpers;

namespace Medidata.RWS.NET.Standard.Core.Responses
{
    public abstract class RwsXmlResponse
    {           
  
        protected RwsXmlResponse(HttpResponseMessage responseMessage)
        {
            ResponseObject = responseMessage;

            ReferenceNumber = RootElement?.Attribute("ReferenceNumber")?.Value;
            InboundODMFileOID = RootElement?.Attribute("InboundODMFileOID")?.Value;
            IsTransactionSuccessful = RootElement?.Attribute("IsTransactionSuccessful")?.Value == "1";

        }

        protected RwsXmlResponse()
        {
            
        }

        /// <summary>
        /// The inbound odm file oid
        /// </summary>
        public readonly string InboundODMFileOID;
        /// <summary>
        /// Whether or not the transaction is successful.
        /// </summary>
        public readonly bool IsTransactionSuccessful;

        /// <summary>
        /// The reference number
        /// </summary>
        public readonly string ReferenceNumber;

        [XmlIgnoreAttribute]
        public HttpResponseMessage ResponseObject { get; protected set; }

        public XElement RootElement => XmlDocument?.Root;

        public XDocument XmlDocument
        {
            get
            {
                try {
                    return RwsHelpers.Xml.GetXDocumentFromString(ResponseObject.Content?.ReadAsStringAsync().Result);
                } catch (XmlException)
                {
                    return null;
                }

            }
        }
    }
}
