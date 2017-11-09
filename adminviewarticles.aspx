<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="adminviewarticles.aspx.cs" Inherits="adminviewarticles" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="gridarticle" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:TemplateField HeaderText="ArticleId">
                <ItemTemplate>
                    
                  <%#Eval("ArticleId") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="ArticleType">
                <ItemTemplate>
                    
                    <%#Eval("ArticleType") %></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="ArticleDesc">
                <ItemTemplate><%#Eval("ArticleDesc") %></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PostDate">
                <ItemTemplate><%#Eval("CDate") %></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="UserName">
                <ItemTemplate>
                    <%#Eval("UserName") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField >
                <ItemTemplate>
                    <asp:LinkButton ID="linnkdelete"  CommandArgument='<%#Eval("ArticleId") %>' Text="Delete" runat="server"  OnClick="linnkdelete_Click"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
   
    <asp:Label ID="lblmsg" runat="server"></asp:Label>
    
</asp:Content>

