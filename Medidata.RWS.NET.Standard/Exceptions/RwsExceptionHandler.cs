﻿using System;
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

            switch (response.StatusCode)
            {
                case HttpStatusCode.BadRequest:
                case HttpStatusCode.NotFound:
                    if (content.StartsWith("<Response", StringComparison.CurrentCulture))
                    {
                        var error = new RwsErrorResponse(response);
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
                    if (content.Contains("<h2>HTTP Error 401.0 - Unauthorized</h2>"))
                    {
                        throw new RwsException("Unauthorized.", response);
                    }

                    IRwsError _error;
                    if (response.RequestMessage.Headers.Any(x => x.Key.Equals("Content-Type") && x.Value.ToString().StartsWith("text/xml", StringComparison.CurrentCulture)))
                    {
                        if (content.StartsWith("<Response", StringComparison.CurrentCulture))
                        {
                            _error = new RwsErrorResponse(response);
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
                        _error = new RwsErrorResponse(response);
                    }
                    throw new RwsException(_error.GetErrorDescription(), response);

            }

            if (!response.IsSuccessStatusCode)
            {
                IRwsError _error;
                if (content.Contains("<"))
                {
                    if (content.Trim().StartsWith("<Response", StringComparison.CurrentCulture))
                    {
                        _error = new RwsErrorResponse(response);
                    }
                    else if (content.Contains("ODM"))
                    {
                        _error = new RwsError(response);
                    }
                    else
                    {
                        throw new RwsException($"Unexpected Status Code ({response.StatusCode.ToString()})", response);
                    }
                }
                else
                {
                    throw new RwsException($"Unexpected Status Code ({response.StatusCode.ToString()})", response);
                }
                throw new RwsException(_error.GetErrorDescription(), _error);
            }
        }
    }
}
