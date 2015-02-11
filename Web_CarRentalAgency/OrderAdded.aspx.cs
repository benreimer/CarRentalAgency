using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace Web_CarRentalAgency
{
    public partial class OrderAdded : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                      
        }


        //public void createOrder(string inventoryID, string customerName, string customerID, DateTime startDate, DateTime endDate)
        //{

        //    int inventory_ID = Convert.ToInt16(inventoryID);
        //    int customer_ID = Convert.ToInt16(customerID);
        //    string customer_Name = customerName;
        //    string rentalLength = calculateRentalLength(startDate, endDate);
        //    int rental_length = Convert.ToInt16(rentalLength);


        //    //update the isAvailable field to false based on the vehicle id
        //    string sqlQuery = "UPDATE INVENTORY SET inventory_isAvailable = 0 WHERE inventory_id= " + inventory_ID;
        //    dbConnection.dbInsert(sqlQuery);

        //    string[] vehicleInfo = getInventoryDetailsByID(inventory_ID).Split(':');
        //    string bodyStyle = vehicleInfo[5];
        //    //because I add a ';' to the end of each result returned from getinventoryDetailsbyID, I need to remove that here
        //    string v1 = vehicleInfo[8];
        //    string[] v2 = v1.Split(';');
        //    string vehicle_upcharge = v2[0];
        //    string[] vehicleRentalFee = getDailyRentalFees(bodyStyle).Split(':');

            
        //    ////anything over 7 days will be charged weekly rate then daily rate for remaining days over 7
        //    int weeks = Convert.ToInt32(rental_length) / 7;
        //    int days = Convert.ToInt32(rental_length) % 7;
           
        //    string daily_rentalFee = vehicleRentalFee[2];
        //    string weekly_rentalFee = vehicleRentalFee[3];

        //    ////now I can calculate my order subtotal/total
        //    decimal order_subtotal = Convert.ToDecimal(vehicle_upcharge) + (Convert.ToDecimal(daily_rentalFee) * days) + (Convert.ToDecimal(weekly_rentalFee) * weeks);

        //    decimal tax_rate = .07M;
        //    decimal order_tax = (order_subtotal * tax_rate);
        //    decimal order_total = order_subtotal + order_tax;

        //    //insert data into OrderDetail table
        //    sqlQuery = "";
        //    sqlQuery = @"INSERT INTO OrderDetail (order_cust_id,order_empl_id,order_inventory_style,order_inventory_id,order_rental_lengthDays, order_subtotal, order_tax,order_total,order_startDate," +
        //        "order_endDate,orderClosed) VALUES ("
        //        //I am hardcoding 2 as the employee id until I have added more logic to get this
        //        + customer_ID + "," + 2 + ",'" + bodyStyle + "'," + inventory_ID + "," + rental_length + "," + order_subtotal +
        //        "," + order_tax + "," + order_total + ",'" + startDate + "','" + endDate + "'," + 0 + ")";

        //    dbConnection.dbInsert(sqlQuery);

        //    //string redirectPage = "OrderAdded.aspx?inventoryID=" + inventory_ID;
        //    string redirectPage = "OrderConfirm.aspx?inventoryID=" + inventory_ID;
        //    Response.Redirect(redirectPage);

        //    ////create a new query here to get the latest order created.  change the output below to include that order number.
        //    //Console.WriteLine("Your order has been added. Press any key to return to the Employee Menu:");
        //    //Console.ReadLine();

        //    //Employee.displayEmployeeOptions();

        //}
     

    }
}