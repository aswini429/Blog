<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="searcharticle.aspx.cs" Inherits="searcharticle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Image ID="img1" runat="server" />
    <br />
   Keyword<asp:TextBox ID="txtarticletype" runat="server"></asp:TextBox><br /><br />
    <asp:LinkButton ID="link1" runat="server" Text="search" OnClick="link1_Click"></asp:LinkButton>
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
            <asp:TemplateField HeaderText="CDate">
                <ItemTemplate>
                    <%#Eval("CDate") %>
                </ItemTemplate>
                            </asp:TemplateField>
            <asp:TemplateField HeaderText="PostedBy">
                <ItemTemplate>
                    <%#Eval("UserName") %>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>

