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
    public class OrderMethods
    {

        public static string getDailyRentalFees(string vehicle_style)
        {

            string rentalFees = "";
            string sqlQuery = "Select * from RentalFees where fee_vehicleStyle = '" + vehicle_style + "'";
            string dbTableName = "RentalFees";
            DataSet queryResults = new DataSet();

            queryResults = dbConnection.dbSelect(sqlQuery, dbTableName);

            //print queryResults
            foreach (DataRow row in queryResults.Tables[dbTableName].Rows)
            {
                rentalFees = String.Format("{0}:{1}:{2}:{3}", row[0], row[1], row[2], row[3]);
            }

            return rentalFees;
        }


        public static string checkAvailableInventory()
        {
            string availableInventory = "";
            //int rowNum = 0;

            string sqlQuery = "select * from inventory where inventory_isAvailable = 1";
            string dbTableName = "inventory";
            DataSet queryResults = new DataSet();

            queryResults = dbConnection.dbSelect(sqlQuery, dbTableName);

            //format each returned row of data
            foreach (DataRow row in queryResults.Tables[dbTableName].Rows)
            {
                availableInventory = availableInventory + String.Format("{0}:{1}:{2}:{3}:{4}:{5}:{6}:{7}:{8};",
                    //availableInventory = availableInventory + String.Format("<tr><td><input type='radio' name='availableinventory' value='{0}'>" + 
                    //  "<td>{4}</td><td>{1}</td><td>{2}</td><td>{6}<td>{8}</td><td>{5}</td></tr>",
                    // call the objects from their index
                row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
            }

            return availableInventory;
        }

        
        public static string calculateRentalLength(DateTime startDate, DateTime endDate)
        {
            DateTime tempDate;
            //if end date is before start date, switch them before calculating
            if (DateTime.Compare(endDate, startDate) < 0)
            {
                tempDate = endDate;
                endDate = startDate;
                startDate = tempDate;
            }

            //now subtract end date from start date
            TimeSpan dateDiff = endDate.Subtract(startDate);

            string diff = Convert.ToString(dateDiff);
            string[] diff2 = diff.Split('.');
            string rentalLength = diff2[0];

            //convert the timespan value to a string
            //string diff = (string)Convert.ChangeType(dateDiff,typeof(string));



            //string[] diff = Convert.ToString(dateDiff);

            //string[] diff = Convert.C
            //string rentalLength = "6";

            return Convert.ToString(rentalLength);
        }


        public static string getInventoryDetailsByID(int inventoryID)
        {
            string inventoryDetails = "";

            string sqlQuery = "select * from inventory where inventory_id=" + inventoryID;
            string dbTableName = "inventory";
            DataSet queryResults = new DataSet();

            queryResults = dbConnection.dbSelect(sqlQuery, dbTableName);

            //format each returned row of data
            foreach (DataRow row in queryResults.Tables[dbTableName].Rows)
            {
                inventoryDetails = inventoryDetails + String.Format("{0}:{1}:{2}:{3}:{4}:{5}:{6}:{7}:{8};",
                    // call the objects from their index
                row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
            }

            return inventoryDetails;
        }


        // this was....  public static void createOrder(string inventoryID, string customerName, string customerID, DateTime startDate, DateTime endDate)
        public static string buildOrderDetails(string inventoryID, string customerName, string customerID, DateTime startDate, DateTime endDate)
        {

            int inventory_ID = Convert.ToInt16(inventoryID);
            int customer_ID = Convert.ToInt16(customerID);
            string customer_Name = customerName;
            string rentalLength = calculateRentalLength(startDate, endDate);
            int rental_length = Convert.ToInt16(rentalLength);


            //update the isAvailable field to false based on the vehicle id
            string sqlQuery = "UPDATE INVENTORY SET inventory_isAvailable = 0 WHERE inventory_id= " + inventory_ID;
            dbConnection.dbInsert(sqlQuery);

            //get the vehicle details based onthe inventory ID
            string[] vehicleInfo = getInventoryDetailsByID(inventory_ID).Split(':');
            string bodyStyle = vehicleInfo[5];
            //because I add a ';' to the end of each result returned from getinventoryDetailsbyID, I need to remove that here
            string v1 = vehicleInfo[8];
            string[] v2 = v1.Split(';');
            string vehicle_upcharge = v2[0];
            string[] vehicleRentalFee = getDailyRentalFees(bodyStyle).Split(':');

            //anything over 7 days will be charged weekly rate then daily rate for remaining days over 7
            int weeks = Convert.ToInt32(rental_length) / 7;
            int days = Convert.ToInt32(rental_length) % 7;
            string daily_rentalFee = vehicleRentalFee[2];
            string weekly_rentalFee = vehicleRentalFee[3];

            ////now I can calculate my order subtotal/total
            decimal order_subtotal = Convert.ToDecimal(vehicle_upcharge) + (Convert.ToDecimal(daily_rentalFee) * days) + (Convert.ToDecimal(weekly_rentalFee) * weeks);

            decimal tax_rate = .07M;
            decimal order_tax = (order_subtotal * tax_rate);
            decimal order_total = order_subtotal + order_tax;

            //I am hardcoding 2 as the employee id until I have added more logic to get this
            string employee_ID = "2";

            //insert data into OrderDetail table
            //sqlQuery = "";
           // sqlQuery = @"INSERT INTO OrderDetail (order_cust_id,order_empl_id,order_inventory_style,order_inventory_id,order_rental_lengthDays, order_subtotal, order_tax,order_total,order_startDate," +
           //     "order_endDate,orderClosed) VALUES ("
                
          //      + customer_ID + "," + employee_ID + ",'" + bodyStyle + "'," + inventory_ID + "," + rental_length + "," + order_subtotal +
           //     "," + order_tax + "," + order_total + ",'" + startDate + "','" + endDate + "'," + 0 + ")";

         //   dbConnection.dbInsert(sqlQuery);

            string details = customer_ID + "," + employee_ID + "," + bodyStyle + "," + inventory_ID + "," + rental_length + "," + order_subtotal + "," + order_tax + "," + order_total + "," + startDate + "," + endDate;
            //string redirectPage = "OrderAdded.aspx?inventoryID=" + inventory_ID;
            string redirectPage = "OrderConfirm.aspx?details=" + details;
            //Response.Redirect(redirectPage);

            return redirectPage;

        }
    }
}