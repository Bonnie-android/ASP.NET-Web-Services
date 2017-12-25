# ASP.NET-Web-Services
Web Services Demos
In ASP.NET Web Service is a class that inherits from the System.Web.Services.WebService base class.
The Web Service is decorated with the [WebService] attribute which indicates that the class contains the code for a web service. This is optional and we can still create web services without inheriting from the System.Web.Services.WebService class, however we will not be able to use the SESSION or APPLICATION variables.

The class is decorated with the WebService attribute: [WebService(Namespace = "http://myWebServices.org/WebServices")] The name space is used to uniquely identify your web service.
A web service is provided with a unique name space to enable users to access it on the web. Example of a web service name space would be 
[WebService(Namespace = “http://mycompany.com/webservice1”)]

My method example is Basic_Calculator_WebService.asmx which accepts two numbers and returns their sum. In order to expose the method to the client application the method must be public and must be decorated with the attribute [WebService] to be accessable.

in progress

