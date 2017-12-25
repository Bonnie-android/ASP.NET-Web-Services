using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for Calculator_WebService
/// </summary>
[WebService(Namespace = "http://myCompanyWebsite.com/WebServices")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class Calculator_WebService : System.Web.Services.WebService
{

    public Calculator_WebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public int Add(int firstNumber, int secondNumber)
    {
        return firstNumber + secondNumber;
    }

}
