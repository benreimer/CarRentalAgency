<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerAdded.aspx.cs" Inherits="Web_CarRentalAgency.CustomerAdded" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
         <asp:HyperLink ID="addAnother" runat="server" NavigateUrl="CustomerAdd.aspx">Click here to add another.</asp:HyperLink>   
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:HyperLink ID="GoBack" runat="server" NavigateUrl="Employee.aspx">Go Back</asp:HyperLink>

    </div>
    </form>
</body>
</html>
