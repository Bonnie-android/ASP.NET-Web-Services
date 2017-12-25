using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CalculatorApp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
    
    //Brings in Proxy Class created when I reference the web service WSDL
        Calculator_Service.Calculator_WebServiceSoapClient client = new Calculator_Service.Calculator_WebServiceSoapClient();
        int result = client.Add(Convert.ToInt32(txtFirstNumber.Text), Convert.ToInt32(txtSecondNumber.Text));
        lblResult.Text = result.ToString();
    }
}
