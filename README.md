
An ASP.NET Web Service is a class that inherits from the System.Web.Services.WebService base class.
The Web Service is decorated with the [WebService] attribute which indicates that the class contains the code for a web service. This is optional and we can still create web services without inheriting from the System.Web.Services.WebService class, however we will not be able to use the .NET SESSION or APPLICATION variables.

The class is decorated with the WebService attribute: [WebService(Namespace = "http://myWebServices.org/WebServices")] The name space is used to uniquely identify your web service.
A web service is provided with a unique name space to enable users to access it on the web. Example of a web service name space would be 
[WebService(Namespace = “http://mycompany.com/webservice”)]

The example method is Calculator_WebService.asmx which accepts two numbers and returns their sum. In order to expose the method to the client application the method must be public and must be decorated with the attribute [WebService] to be exposed to the web client.

This example contains a method called Add which takes in two integers and returns the sum which is of type integer. 
I have also included a client app called Calculator_App which consumes the web service. This client application references the web service and creates a proxy class based on the WSDL of the web service. A client is then created that interacts with the proxy class, Calculator_Service, which in turn interacts with the web service.

--------------------------------------------------------------------------------------------------------
What is a WSDL and what is it's purpose?
WSDL stands for Web Service Description Language and provides a formal definition of a web service. It contains all of the methods that are exposed by the web service.
It contains the parameters and their data types. It also contains the return types of the methods.

How is a proxy class generated?
Visual Studio generates a proxy class using the WSDL document of a web service. The client application calls the proxy class method. The proxy class will then serialize the parameters, prepare a SOAP request message and send it to the web service.
The web service executes the method and returns a SOAP response message to the proxy. The proxy class will then deserialize the SOAP response message and provide it to the client application.

What is the use of a proxy class? 
It is not necessary to serialize and deserialize .NET CLR objects to and from the SOAP format. The proxy class does this automatically.

What happens when a web service reference is added?
A .NET appliction is able to generate a proxy class based on the web service which can be used in any application.

