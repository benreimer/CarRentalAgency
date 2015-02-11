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
    public partial class OrderAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //I need this in order to add items to the panels on the aspx page
            if (ScriptManager.GetCurrent(Page) == null)
            {
                Page.Form.Controls.AddAt(0, new ScriptManager());
            } 
            
            string available_inventory = "";
            
            //check db for a list of available vehicles in inventory.  
            available_inventory = OrderMethods.checkAvailableInventory();
          
            
            if (available_inventory == "")
            {
                Response.Write("<br/>There is currently no available inventory.<br/><br/>");
                Response.Write("<a href='Employee.aspx'>Click here to go back<a />");
            }
            else
            {
                //display order form
                displayOrderForm(available_inventory);
            }

        }

        protected void displayOrderForm(string inventory)
        {
            Response.Write("Please input cusotmer name or ID for this order: <br/>");
           
            //build the controls for the form here
            Label nameLabel = new Label();
            nameLabel.Text = "Customer Name: ";
            Label idLabel = new Label();
            idLabel.Text = "Customer ID: ";
            TextBox nameText =  new TextBox();
            
            nameText.ID = "customerName";
            TextBox idText = new TextBox();
            
            idText.ID = "customerID";
            
            //now write them to the customerName and customerID controls
            nameLabel.DataBind();
            idLabel.DataBind();
            nameText.DataBind();
            idText.DataBind();
            
            customerNameDisplay.Controls.Add(nameLabel);
            customerNameDisplay.Controls.Add(nameText);
            customerIDDisplay.Controls.Add(idLabel);
            customerIDDisplay.Controls.Add(idText);
            
            displayAvailableInventory(inventory); 
        }

        
        private void displayAvailableInventory(string available_inventory)
        {
            RadioButtonList rbl = new RadioButtonList();
            rbl.ID = "availableInventory";
            
            Response.Write("<br/><br/>Here is a list of vehicles currently available in inventory. <br/> Choose one and then click on \"View Details\" <br/><br/>");
            
            string[] currentRow = available_inventory.Split(';');
            foreach (string row in currentRow)
            {
                string[] currentItem = row.Split(':');
                if (row != "")
                {
                    string id = currentItem[0];
                    string make = currentItem[1];
                    string model = currentItem[2];
                    string make_model = make + model;
                    string vin = currentItem[3];
                    string year = currentItem[4];
                    //string style = currentItem[5];
                    //string color = currentItem[6];
                    //string dailyUpcharge = currentItem[8];
                    string description = year + " " + make + " " + model + "(VIN: " + vin + ")";

                    //write out the radio button for each data row
                    rbl.Items.Add(new ListItem(description, id));
                }

            
            }
            rbl.DataBind();
            inventoryDisplay.Controls.Add(rbl);
            
        }

      


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            //get value of selected inventory item(radio button)
            RadioButtonList rb = (RadioButtonList)FindControl("availableInventory");
            string inventoryID = rb.SelectedValue;

            TextBox tb1 = (TextBox)FindControl("customerName");
            TextBox tb2 = (TextBox)FindControl("customerID");
            TextBox tb3 = (TextBox)FindControl("rentalLength");
            string customer_Name = tb1.Text;
            string customer_ID = tb2.Text;

            TextBox tb4 = (TextBox)FindControl("rentalStartDate");
            TextBox tb5 = (TextBox)FindControl("rentalEndDate");
            DateTime startDate = Convert.ToDateTime(tb4.Text);
            DateTime endDate = Convert.ToDateTime(tb5.Text);
           
            string redirectPage = OrderMethods.buildOrderDetails(inventoryID, customer_Name, customer_ID, startDate, endDate);
            //once order details are built, send user to confirmation page
            Response.Redirect(redirectPage); 
        }

    }
}