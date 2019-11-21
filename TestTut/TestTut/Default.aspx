<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TestTut._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <div style="height: 100px; background-color: indianred">
    <asp:Button ID="GetEmployeesBtn" runat="server" Text="Get All Employees" OnClick="GetEmployeesBtn_Click" />
        <asp:Button ID="GetCustomers" runat="server" OnClick="GetCustomers_Click" Text="Button" Width="170px" />
    </div>

     <% } %>
  <div style="">
    <%= site %> 
  </div>
<% } %>
    
    <asp:GridView ID="GridView1" runat="server" style="margin-top: 25px" Width="307px"></asp:GridView>

</asp:Content>
