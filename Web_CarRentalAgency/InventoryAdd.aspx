<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InventoryAdd.aspx.cs" Inherits="Web_CarRentalAgency.InventoryAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #addInventory {
            width: 108px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    On this page, I will present the user with a form to enter new inventory....

           <!--     
            vars - 
             string make = "";
            string model = "";
            int vin = 0;
            int year = 0;
            string style = "";
            string color = "";
            string dailyUpcharge = "";
        -->

        <br />
        <br />
        <br />

        Please add your new vehicle details below:


        <br />
        <br />
        <table>
            <tr>
                <td>
                    <asp:Label ID="label_make" runat="server" Text="Make:"></asp:Label>
                </td>
                <td>

                    <asp:DropDownList ID="make" runat="server" AutoPostBack="True" OnSelectedIndexChanged="fillModelDropDown">
                        <asp:ListItem Text= "Select Make" Selected="True" Value="Select Make"></asp:ListItem>
                        <asp:ListItem>Dodge</asp:ListItem>
                        <asp:ListItem>Ford</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="label_model" runat="server" Text="Model:"></asp:Label>
                </td>
                <td>

                    <asp:DropDownList ID="model" runat="server" AutoPostBack="True" OnSelectedIndexChanged="fillYearDropDown">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="label_vin" runat="server" Text="VIN:"></asp:Label>
                </td>
                <td>

                    <asp:TextBox ID="vin" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="label_year" runat="server" Text="Year:"></asp:Label>
                </td>
                <td>
        
      <asp:DropDownList ID="year" runat="server">
                    </asp:DropDownList>
               
      
     
                  
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="label_style" runat="server" Text="Style:"></asp:Label>
                </td>
                <td>

                    <asp:TextBox ID="style" runat="server" Text="Body Style" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="label_color" runat="server" Text="Color:"></asp:Label>
                </td>
                <td>

                    <asp:TextBox ID="color" runat="server" style="margin-bottom: 0px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="label_dialyUpcharge" runat="server" Text="Daily Upcharge:"></asp:Label>
                </td>
                <td>

                    &nbsp;<asp:TextBox ID="dailyUpcharge" runat="server"></asp:TextBox>
                    
                </td>
            </tr>
        </table>
        
        <br />


        
        
        <asp:Button ID="btnSubmit" runat="server" Text="Add Inventory" OnClick="btnSubmit_Click" />

    </div>
    </form>



</body>

</html>
