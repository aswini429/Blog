<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="ReplyForums.aspx.cs" Inherits="ReplyForums" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <asp:Image ID="image1" runat="server" /><br />
   Question: <asp:Label ID="lblquestion" runat="server"></asp:Label><br />
    <br />
        
   Answer is: <asp:TextBox ID="txtanswer" runat="server"></asp:TextBox>
     <br /><br />
    <asp:Button ID="btnPost" runat="server" Text="PostQuery" OnClick="btnPost_Click" />
    <br />
    <asp:Label ID="lblmsg" runat="server"></asp:Label>
    
   
</asp:Content>