<%@ Page Title="OrderAdd" Language="C#" AutoEventWireup="true" CodeBehind="OrderAdd.aspx.cs" Inherits="Web_CarRentalAgency.OrderAdd" %>


<%@ Register Assembly="System.Web.Extensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI" TagPrefix="asp" %>
<%@ Register TagPrefix="ajax" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>


    <form id="form_OrderAdd" runat="server">
 
       
        <ajaxToolkit:ToolkitScriptManager ID="ToolkitScriptManager" runat="server"></ajaxToolkit:ToolkitScriptManager>
        
 
        
        


        <asp:Panel ID="customerNameDisplay" runat="server"></asp:Panel><br />
        <asp:Panel ID="customerIDDisplay" runat="server"></asp:Panel><br />
   
             <asp:Panel ID="rentalPeriod" runat="server">
            <!-- start date -->
            <asp:Label ID="startDate" runat="server" Text="Rental Start Date:"></asp:Label><br />
            <asp:TextBox ID="rentalStartDate" runat="server" />
            <ajaxToolkit:CalendarExtender TargetControlID="rentalStartDate" runat="server" /> <br />
            <!-- end date -->
            <asp:Label ID="endDate" runat="server" Text="Rental End Date:"></asp:Label><br />
            <asp:TextBox ID="rentalEndDate" runat="server" />
            <ajaxToolkit:CalendarExtender TargetControlID="rentalEndDate" runat="server" /> <br /><br />


                 <br /><br />
           </asp:Panel><br />

        <asp:Panel ID="inventoryDisplay" runat="server"> </asp:Panel> <br />

        <asp:Button ID="btnSubmit" runat="server" Text="View Details" onClick="btnSubmit_Click"/>

         <br/><br/><br/>
         <a href="Employee.aspx">Click here to to back</a>
      </div>   
        
        

    </form>

</body>
</html> 
