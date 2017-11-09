<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server" EnableViewState="true">
    
    <h3 style="font-family:Calibri;color:blue">LoginPage</h3> 
    <table >
        <tr>
            <td> Username</td>
            <td><asp:TextBox ID="txtuname" runat="server"></asp:TextBox></td>
            <%--<td><asp:RequiredFieldValidator ID="revuname" runat="server" ControlToValidate="txtuname" ErrorMessage="please enter username" EnableClientScript="true"></asp:RequiredFieldValidator></td>--%>
        </tr>
        <tr>
            <td>Password</td>
            <td><asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox></td>
           <%-- <td><asp:RequiredFieldValidator ID="rfvpwd" runat="server" ControlToValidate="txtpwd" ErrorMessage="please enter password" EnableClientScript="true"></asp:RequiredFieldValidator>
           --%>               
        </tr>
    </table>
    
   <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" ForeColor="Blue"/>
    <asp:CheckBox ID="checkremeberme" runat="server"  Visible="false"/>RemeberMe<br />
    <asp:HyperLink ID="link1" runat="server" NavigateUrl="ForgotPassword.aspx" Text="ForgotPassword"></asp:HyperLink>
    <asp:Label ID="lblmsg" runat="server"></asp:Label>
</asp:Content>

