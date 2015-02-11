<%@ Page Title="Employee" Language="C#" AutoEventWireup="true" MasterPageFile="~/MyMasterPage.Master" CodeBehind="Employee.aspx.cs" Inherits="Web_CarRentalAgency.Controllers.Employee" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br /><br />
    <div class="content">
        
        <!--this is my content -->

          I will have my Employee Options listed on this page.  This will be the first page after successful login.

        <p>
            &nbsp;</p>
        <p>
            Employee&nbsp; Options</p>
        <table style="width:100%;">
            <tr>
                <td class="auto-style3"><a href="InventorySearch.aspx">Search Inventory</a></td>
                <td class="auto-style4"><a href="InventoryAdd.aspx">Add Inventory</a></td>
                <td class="auto-style5"><a href ="Reports.aspx">Run Reports</a></td>
            </tr>
            <tr>
                <td class="auto-style1"><a href="CustomerSearch.aspx">Search Customers</a></td>
                <td class="auto-style2"><a href="CustomerAdd.aspx">Add Customer</a></td>
                <td class="auto-style2"><a href="Default.aspx">Go Back</a></td>
            </tr>
            <tr>
                <td class="auto-style1"><a href="OrderSearch.aspx">Search Rental Orders</a></td>
                <td class="auto-style2"><a href="OrderAdd.aspx">Create New Rental Order</a></td>
                

            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2"><a href="OrderReturn.aspx">Return Existing Rental</a></td>
                
                <td>&nbsp;</td>
            </tr>
        </table>

      </div>
    </asp:Content>
