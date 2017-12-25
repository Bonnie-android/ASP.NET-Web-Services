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

    [WebMethod (EnableSession =true)]
    public int Add(int firstNumber, int secondNumber)
    {

        //Intent is to save the history of webservice use
        List<string> calculations;
        //upon initial page load create the list holding history
        if(Session["CALCULATIONS"] == null)
        {
            calculations = new List<string>();
        }
        else
        {
            //add current calculation to user history and output to gridview
            calculations = (List<string>)Session["CALCULATIONS"];
        }

        string strRecentCalculation = firstNumber.ToString() + " + " + secondNumber.ToString() + " = " + (firstNumber + secondNumber).ToString();
        calculations.Add(strRecentCalculation);
        Session["CALCULATIONS"] = calculations;
        return firstNumber + secondNumber;
    }

    //return the list of calculations to the client
    [WebMethod(EnableSession =true)]
    public List<string> GetCalcList()
    {
        if(Session["CALCULATIONS"] == null)
        {
            List<string> calculations = new List<string>();
            calculations.Add("You have not done any calculations yet");
            return calculations;
        }
        else
        {
           return (List<string>) Session["CALCULATIONS"];
        }

    }

}
