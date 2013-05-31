using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class getOrders : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("{ \"Orders\": [");
        //if there is no Customer returned


        //Get the connection string and store in a string         
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["BeachyGoDaddy"].ConnectionString;
        //Create a new object for connections
        DataAccess da = new DataAccess();
        //And create a new ds to return data into
        System.Data.DataSet ds = da.GetDataSet(connectionString, "SELECT EmployeeID, OrderID , OProduct, OPrice FROM Beachy_Orders;");

        if (ds != null)
        {
            //if there is no Customers returned
            if (ds.Tables.Count <= 0 || ds.Tables[0].Rows.Count <= 0)
            {
                Response.Write("{}");
            }
            else
            {
                //Loop through the results and display
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    Response.Write("{\"OrderID\": \"" + ds.Tables[0].Rows[i].ItemArray[0].ToString() +
                        "\", \"Product\":" +
                       "\"" + ds.Tables[0].Rows[i].ItemArray[1].ToString() + "\", \"Price\":" + "\"" +
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