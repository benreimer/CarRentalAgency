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
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        private bool EmployeeLogin(string UserName, string Password)
        {
            bool loggedIn = false;
          
            string sqlQuery = "SELECT * FROM Employee WHERE empl_userName = '" + UserName + "' AND empl_Password = '" + Password + "'";
            string dbTableName = "Employee";
            DataSet queryResults = new DataSet();
            int rowCount = 0;
            queryResults = dbConnection.dbSelect(sqlQuery, dbTableName);

            //print queryResults
            foreach (DataRow row in queryResults.Tables[dbTableName].Rows)
            {
                rowCount++;
            }

            if (rowCount > 0)
            {
                loggedIn = true;
            }

            return loggedIn;
        }



        protected void login_Authenticate(object sender, AuthenticateEventArgs e)
        {
            bool Authenticated = false;
            Authenticated = EmployeeLogin(login.UserName, login.Password);

            e.Authenticated = Authenticated;

            if (e.Authenticated)
            {
                Response.Redirect("Employee.aspx");
            }
            else
            {
                Response.Redirect("Contact.aspx");
            }

            
        }
    }
}