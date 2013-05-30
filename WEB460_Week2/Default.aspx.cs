using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        beachy.com.CalculatorSoapClient myclient = new beachy.com.CalculatorSoapClient();
        lblAnswer.Text = myclient.Add(txtNum1.Text, txtNum2.Text);
        lblAnswer.Visible = true;
    }
    protected void btnSub_Click(object sender, EventArgs e)
    {
        beachy.com.CalculatorSoapClient myclient = new beachy.com.CalculatorSoapClient();
        lblAnswer.Text = myclient.Subtract(txtNum1.Text, txtNum2.Text);
        lblAnswer.Visible = true;
    }
    protected void btnMult_Click(object sender, EventArgs e)
    {
        beachy.com.CalculatorSoapClient myclient = new beachy.com.CalculatorSoapClient();
        lblAnswer.Text = myclient.Mulitiply(txtNum1.Text, txtNum2.Text);
        lblAnswer.Visible = true;
    }
    protected void btnDiv_Click(object sender, EventArgs e)
    {
        beachy.com.CalculatorSoapClient myclient = new beachy.com.CalculatorSoapClient();
        lblAnswer.Text = myclient.Divide(txtNum1.Text, txtNum2.Text);        
        lblAnswer.Visible = true;
    }
    protected void btnClear_Click(object sender, EventArgs e)
    {
        txtNum1.Text = "";
        txtNum2.Text = "";
        lblAnswer.Visible = false;
    }
}