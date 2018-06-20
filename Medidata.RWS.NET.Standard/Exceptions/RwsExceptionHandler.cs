using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using Medidata.RWS.NET.Standard.Core;
using Medidata.RWS.NET.Standard.Core.Objects;
using Medidata.RWS.NET.Standard.Core.Responses;

namespace Medidata.RWS.NET.Standard.Exceptions
{
    public static class RwsExceptionHandler
    {

        public static void Parse(HttpResponseMessage response)
        {
            string content = response.Content.ReadAsStringAsync().Result;
            var responseContentTypeHeader = response.Content.Headers.FirstOrDefault(x => x.Key == "Content-Type");

            switch (response.StatusCode)
            {
                case HttpStatusCode.BadRequest:
                case HttpStatusCode.NotFound:
                    if (content.StartsWith("<Response", StringComparison.CurrentCulture))
                    {
                        var error = GenerateResponse(response);
                        throw new RwsException(error.GetErrorDescription(), error);
                    }
                    if (content.Contains("<html"))
                    {
                        throw new RwsException("IIS Error", response);
                    }
                    else
                    {
                        var error = new RwsError(response);
                        throw new RwsException(error.GetErrorDescription(), response);
                    }
                case HttpStatusCode.InternalServerError:
                    throw new RwsException("Server Error (500)", response);
                case HttpStatusCode.Unauthorized:
                    if (content.Contains("Authorization Header not provided"))
                    {
                        throw new RwsAuthorizationException(content);
                    }
                    if (content.Contains("<h2>HTTP Error 401.0 - Unauthorized</h2>"))
                    {
                        throw new RwsException("Unauthorized.", response);
                    }

                    IRwsError _error;

                    if (responseContentTypeHeader.Value.Any(x => x.StartsWith("text/xml", StringComparison.CurrentCulture)))
                    {
                        if (content.StartsWith("<Response", StringComparison.CurrentCulture))
                        {
                            _error = GenerateResponse(response);
                        }
                        else if (content.Contains("ODM"))
                        {
                            _error = new RwsError(response);
                        }
                        else
                        {
                            throw new RwsException("Unspecified Error.", response);
                        }

                    }
                    else
                    {
                        _error = GenerateResponse(response);
                    }
                    throw new RwsException(_error.GetErrorDescription(), _error);

            }

            if (!response.IsSuccessStatusCode)
            {
                IRwsError _error;
                if (content.Contains("<"))
                {
                    if (content.Trim().StartsWith("<Response", StringComparison.CurrentCulture))
                    {
                        _error = GenerateResponse(response);
                    }
                    else if (content.Contains("ODM"))
                    {
                        _error = new RwsError(response);
                    }
                    else
                    {
                        throw new RwsException($"Unexpected Status Code ({(int)response.StatusCode})", response);
                    }
                }
                else
                {
                    throw new RwsException($"Unexpected Status Code ({(int)response.StatusCode})", response);
                }
                throw new RwsException(_error.GetErrorDescription(), _error);
            }
        }

        static IRwsError GenerateResponse(HttpResponseMessage message)
        {
            if (message.RequestMessage.Method == HttpMethod.Post)
            {
                return new RwsPostErrorResponse(message);
            }

            return new RwsErrorResponse(message);
        }
    }
}
