<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerAdd.aspx.cs" Inherits="Web_CarRentalAgency.CustomerAdd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    This will be the add customer page .....<br /><br />

        Please fill in the form below <br />

        <br />

        <asp:Table ID="Table1" runat="server">
            <asp:TableRow>
                <asp:TableCell><asp:Label ID="label_firstname" runat="server" Text="First Name: "></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID ="firstname" runat="server" Text="First Name"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
                        <asp:TableRow>
                <asp:TableCell><asp:Label ID="label_lastname" runat="server" Text="Last Name: "></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID ="lastname" runat="server" Text="Last Name"></asp:TextBox></asp:TableCell>
            </asp:TableRow>
                                    <asp:TableRow>
                <asp:TableCell><asp:Label ID="label_address1" runat="server" Text="Address Line 1: "></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID ="address1" runat="server" Text="Address Line 1"></asp:TextBox></asp:TableCell>
            </asp:TableRow>

                                    <asp:TableRow>
                <asp:TableCell><asp:Label ID="label_address2" runat="server" Text="Address Line 2: "></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID ="address2" runat="server" Text="Address Line 2"></asp:TextBox></asp:TableCell>
            </asp:TableRow>

                                    <asp:TableRow>
                <asp:TableCell><asp:Label ID="lable_city" runat="server" Text="City: "></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID ="city" runat="server" Text="City"></asp:TextBox></asp:TableCell>
            </asp:TableRow>

                                    <asp:TableRow>
                <asp:TableCell><asp:Label ID="label_state" runat="server" Text="State: "></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID ="state" runat="server" Text="State"></asp:TextBox></asp:TableCell>
            </asp:TableRow>

                                    <asp:TableRow>
                <asp:TableCell><asp:Label ID="label_zip" runat="server" Text="Zip Code: "></asp:Label></asp:TableCell>
                <asp:TableCell><asp:TextBox ID ="zip" runat="server" Text="Zip Code"></asp:TextBox></asp:TableCell>
            </asp:TableRow>

        </asp:Table>
        <br />

        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
        <br />

    </div>
    </form>
</body>
</html>
