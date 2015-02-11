using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Web_CarRentalAgency
{
    public partial class InventoryAdded : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string tablestring = "";
            tablestring =tablestring + " <br /><br /><table id=\"InventoryData\" border=\"1\" class=\"auto-style1\" contenteditable=\"false\" draggable=\"false\" style=\"width: 25%;\" title=\"Inventory Data\">";
           // string inventoryData = "";
            string sqlQuery = "select top 1 * from inventory order by inventory_id desc";
            string TableName = "inventory";
            DataSet queryResults = new DataSet();
            queryResults = dbConnection.dbSelect(sqlQuery, TableName);
            foreach (DataRow row in queryResults.Tables[TableName].Rows)
            {
                //inventoryData = String.Format("{1}:{2}:{3}:{4}:{5}:{6}:{8}", row[1],row[2],row[3],row[4],row[5],row[6],row[8]);
                  tablestring=tablestring+
                      //"<tr><td>Make</td><td>"+row[0].ToString()+"</td></tr>"+
			    "<tr><td>Make: </td><td>"+row[1].ToString()+"</td></tr>"+
			    "<tr><td>Model: </td><td>"+row[2].ToString()+"</td></tr>"+
			    "<tr><td>VIN: </td><td>"+row[3].ToString()+"</td></tr>"+
			    "<tr><td>Year: </td><td>"+row[4].ToString()+"</td></tr>"+
			    "<tr><td>Body Style: </td><td>"+row[5].ToString()+"</td></tr>"+
                "<tr><td>Color: </td><td>"+row[6].ToString()+"</td></tr>"+
                "<tr><td>Daily Upcharge: </td><td>"+row[8].ToString()+"</td></tr>";

            }

            tablestring = tablestring + "</table><br/><br/>";

            Response.Write("<br/>You have added the following details the inventory table.");
            Response.Write(tablestring);



        }
    }
}