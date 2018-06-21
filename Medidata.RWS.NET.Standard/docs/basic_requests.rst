
============================================
Basic Requests
============================================

Medidata.RWS.NET.Standard provides some basic diagnostic / health check API requests out of the box.

VersionRequest()
================
Returns the RWS version number. Specifically, this is the textual response returned when calling ``https://{ subdomain }.mdsol.com/RaveWebServices/version``.

.. code-block:: c#

	using Medidata.RWS.NET.Standard.Core.Requests;

	//Create a connection
	var connection = new RwsConnection("innovate"); // no authentication required

	//Send the request / get a response
	var response = connection.SendRequest(new VersionRequest()) as RWSTextResponse;

	//Write the response text to the console
	Console.Write(response.ResponseText);
	//1.15.0
   

TwoHundredRequest()
===================
Returns the html document (along with a 200 HTTP response code) that contains information about the MAuth configuration of Rave Web Services with the given configuration.
Specifically, this is the html response returned when calling ``https://{ subdomain }.mdsol.com/RaveWebServices/twohundred``.

.. code-block:: c#

	using Medidata.RWS.NET.Standard.Core.Requests;

	//Create a connection
	var connection = new RwsConnection("innovate"); // no authentication required

	//Send the request / get a response
	var response = connection.SendRequest(new TwoHundredRequest()) as RWSTextResponse;

	//Write the response text to the console
	Console.Write(response.ResponseText);
	//<!DOCTYPE html>\r\n<html>\r\n<head><script..........
    