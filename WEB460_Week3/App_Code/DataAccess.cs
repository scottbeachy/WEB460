using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

/// <summary>
/// Summary description for dataAccess
/// </summary>
public class DataAccess
{
	public DataAccess()
	{
		//
		// TODO: Add constructor logic here
		// We dont need no stinking logic!
	}

    public DataSet GetData(string queryString, string sqlStatement)
    {
        try
        {
            string connectionString = queryString;
            string sql = sqlStatement;

            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();

            conn.ConnectionString = connectionString;
            //string sql = "SELECT employeeID , firstname, lastname FROM Beachy;";
            System.Data.DataSet ds = new System.Data.DataSet();
            conn.Open();
            System.Data.SqlClient.SqlCommand comm = new System.Data.SqlClient.SqlCommand(sql, conn);

            System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
            da.SelectCommand = comm;
            da.Fill(ds);


            return ds;
        }
        catch (SqlException se)
        {
            return null;
        }

    }

    public DataTable GetDataTable(string queryString, string sqlStatement)
    {
        try
        {

            //Construct and execute the connection and the select statement
            string connectionString = queryString;
            string sql = sqlStatement;

            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();

            conn.ConnectionString = connectionString;
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand comm = new SqlCommand(sql, conn);

            da.SelectCommand = comm;
            //fill the datatable
            da.Fill(dt);
            return dt;
        }
        catch (SqlException se)
        {
            return null;
        }
    }

    public bool DataPuterInner(string queryString, string sqlStatement)
    {
        string sql = sqlStatement;
        string connectionString = queryString;
        try
        {
            
            System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection();
            conn.ConnectionString = connectionString;
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }
        catch (SqlException se)
        {
            return false;
        }
    }
    
}