<%@ Page Title="" Language="C#" MasterPageFile="~/GoMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="COMP231_Group_Project.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Login</h1>
    <p>Username:<br />
<asp:TextBox id="txtUsername" runat="server" />
</p>
<p>Password:<br />
<asp:TextBox id="txtPassword" runat="server" TextMode="Password" />
</p>
<p><asp:Button id="btnLogin" runat="server" Text="Login"
OnClick="LoginUser" />
    <asp:Button ID="btnSignUp" runat="server" OnClick="btnSignUp_Click" Text="Sign Up" />
</p>
</asp:Content>
