<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
            <table>
    
                <tr>
                    <td><asp:Image ID="image1" runat="server" /> </td>
                    <td ><asp:TextBox ID="txtmsg" runat="server" Text=" .Net community is a community website for .net users that can help wide spread,disparate offline communities to cometogether,connect and share thoughts,ideas and valuable thoughts" TextMode="MultiLine" Height="100px" Width="500px" ForeColor="Blue" BackColor="PowderBlue" Font-Bold="true"></asp:TextBox>
    </td>
                </tr>
               

            </table>
       
</asp:Content>

