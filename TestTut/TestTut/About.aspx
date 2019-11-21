<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="TestTut.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  <% foreach (var site in Sites) { %> <!-- loop through the list -->
  <div>
    <%= site %> <!-- write out the name of the site -->
  </div>
<% } %> <!--End the for loop -->
</asp:Content>
