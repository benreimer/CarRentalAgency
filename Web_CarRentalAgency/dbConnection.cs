using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// This is my dbConnection class.  It will setup my dbConnection.
/// It has two methods: 
///     1. dbSelect - method will take sqlQuery and TableName as input and will return selected data from database
///     2. dbInsert - mthod will take sqlQuery as input and will input data from sqlQuery into database tables.
/// </summary>
public class dbConnection
{

    //database connection information
    //home
    //public static string databaseName = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='C:\Users\blreimer\Source\Workspaces\CarRentalAgency\CarRentalAgency\CarRentalAgency\CarRentalAgency.mdf';Integrated Security=True";
    //work
    //public static string databaseName = @"Data Source=(LocalDB)\v11.0;AttachDbFilename='c:\users\br022737\documents\visual studio 2013\Projects\Web_CarRentalAgency\Web_CarRentalAgency\App_Data\Web_CarRentalAgency.mdf';Integrated Security=True";
    public static string databaseName = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Web_CarRentalAgency\Web_CarRentalAgency\App_Data\Web_CarRentalAgency.mdf;Integrated Security=True";

    public static DataSet dbSelect(string sqlQuery, string dbTableName)
    {
        //create new dataset
        DataSet ds = new DataSet();
        using (SqlConnection conn = new SqlConnection())
        {
            conn.ConnectionString = databaseName;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, conn);
            adapter.Fill(ds, dbTableName);
            conn.Dispose();
        }
        return ds;
    }


    public static void dbInsert(string sqlQuery)
    {
        using (SqlConnection conn = new SqlConnection())
        {
            conn.ConnectionString = databaseName;

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = sqlQuery;
            cmd.Connection = conn;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            conn.Dispose();
        }
    }
}
