
<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Uploadproject.aspx.cs" Inherits="Uploadproject" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td>Project Id</td>
            <td><asp:Label ID="lblid" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td>Project Type</td>
            <td><asp:TextBox ID="txtprojecttype" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Upload a project</td>
            <td><asp:FileUpload ID="Flupload" runat="server" /></td>
        </tr>
       
    </table>
     <asp:Button ID="btnupload" runat="server" Text="Upload" OnClick="btnupload_Click" /><br />
    <asp:Label ID="lblmsg" runat="server"></asp:Label>
</asp:Content>

