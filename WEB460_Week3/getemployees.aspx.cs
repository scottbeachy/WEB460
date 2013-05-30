using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class getemployees : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("{ \"employees\": [");
        //if there is no employees returned
        
        
        //Get the connection string and store in a string         
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["BeachyGoDaddy"].ConnectionString;
        //Create a new object for connections
        DataAccess da = new DataAccess();
        //And create a new ds to return data into
        System.Data.DataSet ds = da.GetData(connectionString, "SELECT employeeID , firstname, lastname FROM Beachy;");

        if (ds != null)
        {
            //if there is no employees returned
            if (ds.Tables.Count <= 0 || ds.Tables[0].Rows.Count <= 0)
            {
                Response.Write("{}");
            }
            else
            {
                //Loop through the results and display
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Response.Write("{\"employeeid\": \"" + ds.Tables[0].Rows[i].ItemArray[0].ToString() +
                        "\", \"firstname\":" +
                       "\"" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "\", \"lastname\":" + "\"" +
                       ds.Tables[0].Rows[i].ItemArray[2].ToString() + "\"}");

                    if (i < ds.Tables[0].Rows.Count - 1)
                    {
                        Response.Write(",");
                    }

                }
            }

            Response.Write("]}");
        }
        else
        {
            Response.Write("{}");
        }

    }
}