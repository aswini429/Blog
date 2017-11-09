<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="PostSrticle.aspx.cs" Inherits="PostSrticle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Image ID="img1" runat="server" />
    <table>
        <tr>
            <td> Article id:</td>
            <td> <asp:Label ID="lblid" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td> Article type:</td>
            <td> <asp:TextBox ID="txttype" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td> Article Description</td>
            <td> <asp:TextBox ID="txtdesc" runat="server" TextMode="MultiLine"></asp:TextBox></td>
        </tr>
        
        
    </table>
    <asp:Button ID="btnpost" runat="server" Text="PostArticle" OnClick="btnpost_Click" />
    <asp:Label ID="lblmsg" runat="server"></asp:Label>
</asp:Content>

