<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Web_CarRentalAgency._Default" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <!--
    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>
    -->

    <div class="row">
        <div class="col-md-4">
            <center>

                <h2>Car Rental Agency</h2>
            <h2>Employee Login Page</h2>
            
            <p>
              
            
                    <br />
                    <asp:Login ID="login" runat="server" OnAuthenticate="login_Authenticate">
                    </asp:Login>

                                           
            
                    <br />

 
            </center>

            </p>
           </div>
    </div>

</asp:Content>
