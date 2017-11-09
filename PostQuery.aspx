<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="PostQuery.aspx.cs" Inherits="PostQuery" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Image ID="image1" runat="server" />
    
    Question
    <asp:TextBox ID="txtquestion" runat="server" ></asp:TextBox><br />
    <asp:TextBox ID="txtid" runat="server" Visible="false"></asp:TextBox><br/>
    <asp:TextBox ID="txtlogin" runat="server" Visible="false"></asp:TextBox>
    <asp:Button ID="btnpost" runat="server" Text="PostQuery" OnClick="btnpost_Click" />
    <asp:Label ID="lblmsg" runat="server"></asp:Label>
</asp:Content>

