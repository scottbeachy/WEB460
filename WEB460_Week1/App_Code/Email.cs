using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Text;

/// <summary>
/// This class sends email from the server. 
/// </summary>
public class Email
{
	public Email()
	{
		
	}

    public void Send(string fName, string lName, string email, string addr, string city, string state, string zip, string ccnum, string exp)
    {
        string _fName = fName;
        string _lName = lName;
        string _addr = addr;
        string _city = city;
        string _state = state;
        string _zip = zip;
        string _ccnum = ccnum;
        string _exp = exp;
        string _email = email;

        MailMessage mail = new MailMessage("Trucktech91@gmail.com", _email);

        StringBuilder sb = new StringBuilder();
        sb.Append("Order from " + _fName + " " + _lName);
        mail.Subject = sb.ToString();
        StringBuilder sb2 = new StringBuilder();
        sb2.Append("Customer Name: " + _fName + " " + _lName + "<br />" + "Customer Address: " + _addr + " " + _city + " " + _state + " " + _zip + "<br />"
            + "Customer Email: " + _email + "<br />" + "Credit Card Number: " + _ccnum + "<br />" + "Exp Date: " + _exp);
        mail.Body = sb2.ToString();
        mail.IsBodyHtml = true;

        SmtpClient smtp = new SmtpClient("localhost");
        smtp.Send(mail);
    }
}