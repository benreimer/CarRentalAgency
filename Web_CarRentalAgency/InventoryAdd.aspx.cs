using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Web_CarRentalAgency
{
    public partial class InventoryAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         //fill make drop down
           // fillMakeDropDown();
              


        }


        public void fillMakeDropDown()
        {
            throw new NotImplementedException();
        }


        //compile errors if I did not include object,EventArgs on this method
        public void fillModelDropDown(object sender, EventArgs e)
        {
            int itemCount = 0;
            string currentModel = "";
            string currentMake = make.SelectedItem.Value;
            //find all models based on the selected make
            string sqlQuery = "Select Model from MakeModelYear where Make = '" + currentMake + "'";
            string TableName = "MakeModelYear";
            DataSet queryResults = new DataSet();
            queryResults = dbConnection.dbSelect(sqlQuery, TableName);

            //clear model dropdown list
            model.Items.Clear();
            style.Text = "";
            year.Items.Clear();
            
            //set default value of drop down list
            model.Items.Insert(0, new ListItem("<Select Model>", "0")); 
            
            foreach (DataRow row in queryResults.Tables[TableName].Rows)
            {
                itemCount++;
                currentModel = String.Format("{0}",row[0]);
                //add each item to the drop down list
                model.Items.Add(currentModel);
            }
        }


        public void fillYearDropDown(object sender, EventArgs e)
        {
            
            //I would like to get this into its own method but that was not working.....look into this.
            //fill out style based on chosen model
            string currentModel = model.SelectedItem.Value;
            //find body style based on selected make
            string sqlQuery = "Select top 1 BodyStyle from MakeModelYear where Model = '" + currentModel + "'";
            string TableName = "MakeModelYear";
            DataSet queryResults = new DataSet();
            queryResults = dbConnection.dbSelect(sqlQuery, TableName);

            //set default value of drop down list
            //year.Items.Insert(0, new ListItem("<Select Year>", "0"));

            foreach (DataRow row in queryResults.Tables[TableName].Rows)
            {
                //temCount++;
                string bodyStyle = String.Format("{0}", row[0]);
                style.Text = bodyStyle;
            }
            
            
            //int itemCount = 0;
            //currentModel = model.SelectedItem.Value;
            //find all valid years based on selected model
            sqlQuery = "Select YearsValid from MakeModelYear where Model = '" + currentModel + "'";
            TableName = "MakeModelYear";
            //queryResults = new DataSet();
            queryResults = dbConnection.dbSelect(sqlQuery, TableName);

            //clear year dropdown list
            year.Items.Clear();
            //set default value of drop down list
            year.Items.Insert(0, new ListItem("<Select Year>", "0"));

            foreach (DataRow row in queryResults.Tables[TableName].Rows)
            {
               //temCount++;
                string validYears = String.Format("{0}", row[0]);
                //add this result to an array
                string[] yearList;
                //split the array on comma to get individual years
                yearList= validYears.Split(',');
                //add each year to the drop down list
                foreach(string currentYear in yearList)
                {
                    year.Items.Add(currentYear);
                }
           }

        }





        public void fillStyleLabel(object sender, EventArgs e)
        {
            //int itemCount = 0;
            
        }



        public void btnSubmit_Click(object sender, EventArgs e)
        {
            //this will insert the data in the form to the database

            //collect data to send to the database
           
            
            //vars
            string inputMake = make.SelectedItem.Value;
            string inputModel = model.SelectedItem.Value;
            
            string inputVIN = vin.Text;
            string inputYear = year.SelectedItem.Value;
            string inputStyle = style.Text;
            string inputColor = color.Text;
            string inputDailyUpcharge = dailyUpcharge.Text;

            //insert user input data into the database
            string sqlQuery = @"INSERT INTO Inventory (inventory_make,inventory_model,inventory_vin,inventory_year,inventory_style,inventory_color, inventory_isAvailable, inventory_dailyRentalUpcharge) VALUES ('" + inputMake + "','" + inputModel
                                + "'," + inputVIN + "," + inputYear + ",'" + inputStyle + "','" + inputColor + "',1," + inputDailyUpcharge + ")";
            //string sqlQuery = @"INSERT INTO Inventory (inventory_make,inventory_model,inventory_year,inventory_style,inventory_isAvailable) VALUES ('" + inputMake + "','" + inputModel
             //                   + "'," + inputYear + ",'" + inputStyle  + "',1)";
            dbConnection.dbInsert(sqlQuery);

            Response.Redirect("InventoryAdded.aspx");
        }

      
    }
}