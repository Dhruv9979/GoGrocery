<%@ Page Title="" Language="C#" MasterPageFile="~/GoMaster.Master" AutoEventWireup="true" CodeBehind="Signup.aspx.cs" Inherits="COMP231_Group_Project.Signup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
       <span class="widelabel">Full Name:</span>
    <asp:TextBox ID="txtFullName" runat="server" />
    <br />
    <span class="widelabel">User Name:</span>
    <asp:TextBox ID="txtUserName" runat="server" />
    <br />
    <span class="widelabel">Email:</span>
    <asp:TextBox ID="txtEmail" runat="server" />
    <br />
    <span class="widelabel">Password:</span>
    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"/>
    <br />
    <span class="widelabel">Confirm Password:</span>
    <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"/>
    <br />
  </p>
  <p>
    <asp:Button ID="btnSignUp" Text="SignUp" 
        Width="200" runat="server" 
        onclick="updateButton_Click" />
</asp:Content>
