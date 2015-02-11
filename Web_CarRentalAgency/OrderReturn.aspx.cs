using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_CarRentalAgency
{
    public partial class OrderReturn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Please enter either the vehicle VIN number or rental order number to return: ");
        }
    }
}