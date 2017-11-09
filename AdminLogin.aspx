<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="AdminLogin.aspx.cs" Inherits="AdminLogin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td>UserName</td>
            <td><asp:TextBox ID="txtuname" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Password</td>
            <td><asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox></td>
        </tr>
    </table>
    <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click" />

</asp:Content>

