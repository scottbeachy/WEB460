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
        //Give focus to the textbox for customer first name
        txtFName.Focus();
    }
    protected void btnPurchase_Click(object sender, EventArgs e)
    {
        //create new email object and send a message
        Email email = new Email();
        email.Send(txtFName.Text, txtLName.Text, txtEmail.Text, txtAddr.Text, txtCity.Text, txtState.Text, txtZip.Text, txtCardNum.Text, txtExpDate.Text);
    }
}