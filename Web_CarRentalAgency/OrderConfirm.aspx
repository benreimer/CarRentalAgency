<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderConfirm.aspx.cs" Inherits="Web_CarRentalAgency.OrderConfirm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    

                 <asp:Button ID="yesBtn" runat="server" Text="Yes, continue...." onClick="yesBtn_Click"/>

         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

         <asp:Button ID="noBtn" runat="server" Text="No, Go Back...." onClick="noBtn_Click"/>


    </div>
    </form>
</body>
</html>
