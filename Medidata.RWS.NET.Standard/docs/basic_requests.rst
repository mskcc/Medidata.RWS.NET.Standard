============================================
Basic Requests
============================================

Medidata.RWS.NET.Standard provides some basic diagnostic / health check API requests out of the box.

VersionRequest()
================
Returns the RWS version number. Specifically, this is the textual response returned when calling ``https://{ subdomain }.mdsol.com/RaveWebServices/version``.

.. code-block:: c#

    //Create a connection
    var connection = new RwsConnection("innovate"); // no authentication required

    //Send the request / get a response
    var response = await connection.SendRequestAsync(new VersionRequest()) as RwsTextResponse;

    //Write the response text to the console
    Console.Write(await response.ResponseObject.Content.ReadAsStringAsync());

    //1.16.0


TwoHundredRequest()
===================
Returns the html document (along with a 200 HTTP response code) that contains information about the MAuth configuration of Rave Web Services with the given configuration.
Specifically, this is the html response returned when calling ``https://{ subdomain }.mdsol.com/RaveWebServices/twohundred``.

.. code-block:: c#

    //Create a connection
    var connection = new RwsConnection("innovate"); // no authentication required

    //Send the request / get a response
    var response = await connection.SendRequestAsync(new TwoHundredRequest()) as RwsTextResponse;

    //Write the response text to the console
    Console.Write(await response.ResponseObject.Content.ReadAsStringAsync());

    //<!DOCTYPE html>\r\n<html>\r\n<head><script..........
