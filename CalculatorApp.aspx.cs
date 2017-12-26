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
        Calculator_Service.Calculator_WebServiceSoapClient client = new Calculator_Service.Calculator_WebServiceSoapClient();
        int result = client.Add(Convert.ToInt32(txtFirstNumber.Text), Convert.ToInt32(txtSecondNumber.Text));
        lblResult.Text = result.ToString();
        // List<string> calcList = client.GetCalcList();
        gridCalcHistory.DataSource = client.GetCalcList();
        gridCalcHistory.DataBind();
        //provide a descriptive header for the grid summary
        gridCalcHistory.HeaderRow.Cells[0].Text = "Summary of Calculations";
        
    }
}