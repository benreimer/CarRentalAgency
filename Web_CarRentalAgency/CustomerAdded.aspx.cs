using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.DataAccess;
using System.Data.SqlClient;
using System.Data;

namespace Web_CarRentalAgency
{
    public partial class CustomerAdded : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            string tablestring = "";
            tablestring = tablestring + " <br /><br /><table id=\"InventoryData\" border=\"1\" class=\"auto-style1\" contenteditable=\"false\" draggable=\"false\" style=\"width: 25%;\" title=\"Customer Data\">";
            string sqlQuery = "select top 1 * from customer order by cust_id desc";
            string TableName = "customer";
            DataSet queryResults = new DataSet();
            queryResults = dbConnection.dbSelect(sqlQuery, TableName);
            foreach (DataRow row in queryResults.Tables[TableName].Rows)
            {

               tablestring = tablestring +
                    //"<tr><td>Make</td><td>"+row[0].ToString()+"</td></tr>"+
              "<tr><td>First Name: </td><td>" + row[1].ToString() + "</td></tr>" +
              "<tr><td>Last Name: </td><td>" + row[2].ToString() + "</td></tr>" +
              "<tr><td>Address Line 1: </td><td>" + row[3].ToString() + "</td></tr>" +
              "<tr><td>Address Line 2: </td><td>" + row[4].ToString() + "</td></tr>" +
              "<tr><td>City: </td><td>" + row[5].ToString() + "</td></tr>" +
              "<tr><td>State: </td><td>" + row[6].ToString() + "</td></tr>" +
              "<tr><td>Zip: </td><td>" + row[7].ToString() + "</td></tr>";

            }

            tablestring = tablestring + "</table><br/><br/>";

            Response.Write("<br/>You have added the following customer details to the customer table.");
            Response.Write(tablestring);



        }
    }
}