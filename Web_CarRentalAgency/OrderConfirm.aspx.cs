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
    public partial class OrderConfirm : System.Web.UI.Page
    {
        string details;
        string sqlQuery = "";
        string customer_ID;
        string employee_ID;
        string bodyStyle;
        string inventory_ID;
        string rental_length;
        string order_subtotal;
        string order_tax;
        string order_total;
        DateTime startDate;
        DateTime endDate;
        string make;
        string model;
        string year;
        string color;
        string dailyUpcharge;


        
        
        public void Page_Load(object sender, EventArgs e)
        {
            
                
                //string buttonClicked = "";
            details = Request.QueryString["details"];

            string[] orderDetails = details.Split(',');
            customer_ID=orderDetails[0];
            employee_ID=orderDetails[1];
            bodyStyle=orderDetails[2];
            inventory_ID=orderDetails[3];
            rental_length=orderDetails[4];
            order_subtotal=orderDetails[5];
            order_tax=orderDetails[6];
            order_total=orderDetails[7];
            startDate=Convert.ToDateTime(orderDetails[8]);
            endDate = Convert.ToDateTime(orderDetails[9]);
            
            

            //inventoryID = "10";
            string inventory = OrderMethods.getInventoryDetailsByID(Convert.ToInt16(inventory_ID));
            //trim the semicolon off the end of this string (inventory)
            char[] MyChar = { ';'};
            inventory = inventory.TrimEnd(MyChar);


            string[] inventoryDetails = inventory.Split(':');
            make = inventoryDetails[1];
            model = inventoryDetails[2];
            year =inventoryDetails[4];
            color= inventoryDetails[6];
            dailyUpcharge = inventoryDetails[8];

            
           string pageData = "";
           pageData = pageData + "Below are your order details.  Click 'Yes' to proceed or 'BACK' to cancel:<br/><br/>";
           pageData = pageData + "<table><tr><td>MAKE</td><td>MODEL</td><td>YEAR</td><td>etc</td></tr>";
           pageData = pageData + "<tr><td>" + make + "</td><td>" + model + "</td><td>" + year + "</td><td>etc....</td></tr>";
           Response.Write(pageData);
        }


        public void yesBtn_Click(object sender, EventArgs e)
        {
            //user has selected yes.  add order details to the database
            string pageData = "";
            pageData = pageData + "user has selected yes.  add order details to the database";

            //insert data into OrderDetail table
            sqlQuery = @"INSERT INTO OrderDetail (order_cust_id,order_empl_id,order_inventory_style,order_inventory_id,order_rental_lengthDays, order_subtotal, order_tax,order_total,order_startDate," +
                 "order_endDate,orderClosed) VALUES ("

                  + customer_ID + "," + employee_ID + ",'" + bodyStyle + "'," + inventory_ID + "," + rental_length + "," + order_subtotal +
                 "," + order_tax + "," + order_total + ",'" + startDate.Date + "','" + endDate.Date + "'," + 0 + ")";

               dbConnection.dbInsert(sqlQuery);

            Response.Write(pageData);
            Response.Redirect("Employee.aspx");
        }

        public void noBtn_Click(object sender, EventArgs e)
        { 
            //user has selcted no.  set inventory back to available and return to order screen
            string pageData = "";
            pageData = pageData + "user has selcted no.  set inventory back to available and return to order screen";
            Response.Write(pageData);

            //set the vehicle back to available in the inventory table
            //update the isAvailable field to false based on the vehicle id
            sqlQuery = "UPDATE INVENTORY SET inventory_isAvailable = 1 WHERE inventory_id= " + inventory_ID;
            dbConnection.dbInsert(sqlQuery); 
            //now go back to the employee page
            Response.Redirect("Employee.aspx");
        }


        
    }
}