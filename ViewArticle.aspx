<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="ViewArticle.aspx.cs" Inherits="ViewArticle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="gridview1" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:TemplateField HeaderText="ArticleType">
                <ItemTemplate>
                    <%#Eval("ArticleType") %>                   
                </ItemTemplate>
                
            </asp:TemplateField>
            <asp:TemplateField HeaderText="ArticleDesc">
                <ItemTemplate>
                    <%#Eval("ArticleDesc") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PostedDate">
                <ItemTemplate>
                    <%#Eval("cdate") %>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Postedby">
                <ItemTemplate>
                    <%#Eval("UserName") %>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>

