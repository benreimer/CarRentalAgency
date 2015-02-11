using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_CarRentalAgency
{
    public partial class TestPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, System.EventArgs e)
        {
            tbl.BorderStyle = BorderStyle.Inset;
            tbl.BorderWidth = Unit.Pixel(1);
        }

        protected void cmdCreate_Click(object sender, System.EventArgs e)
        {
            tbl.Controls.Clear();

            int rows = Int32.Parse(txtRows.Text);
            int cols = Int32.Parse(txtCols.Text);

            for (int i = 0; i < rows; i++)
            {
                TableRow rowNew = new TableRow();
                tbl.Controls.Add(rowNew);
                for (int j = 0; j < cols; j++)
                {
                    TableCell cellNew = new TableCell();
                    Label lblNew = new Label();
                    lblNew.Text = "(" + i.ToString() + "," + j.ToString() + ")<br />";

                    System.Web.UI.WebControls.Image imgNew = new System.Web.UI.WebControls.Image();
                    imgNew.ImageUrl = "cellpic.png";

                    cellNew.Controls.Add(lblNew);
                    cellNew.Controls.Add(imgNew);

                    if (chkBorder.Checked == true)
                    {
                        cellNew.BorderStyle = BorderStyle.Inset;
                        cellNew.BorderWidth = Unit.Pixel(1);
                    }

                    rowNew.Controls.Add(cellNew);
                }
            }
        }
    }
}