<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="Viewprojects.aspx.cs" Inherits="Viewprojects" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    Keyword <asp:TextBox  ID="txtserach" runat="server"></asp:TextBox>&nbsp
    <asp:LinkButton ID="linksearch" runat="server" Text="Search"  CommandName="Search" OnClick="linksearch_Click"></asp:LinkButton><br /><br />
    <asp:Button ID="btnDownload" runat="server" Text="Excel" OnClick="btnDownload_Click"></asp:Button>
    <asp:GridView ID="gridprojects" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="gridprojects_SelectedIndexChanged">
        <Columns>
            <asp:TemplateField HeaderText="ProjectType">
                <ItemTemplate>
                    <asp:Label ID="lblpid" runat="server"></asp:Label>
                    <%#Eval("ProjectType") %></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="FileName">
                <ItemTemplate><%#Eval("FileName") %></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="FileType">
                <ItemTemplate><%#Eval("FileType") %></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PostedBy">
                <ItemTemplate><%#Eval("UserName") %></ItemTemplate>
            </asp:TemplateField>
           <%--<asp:TemplateField>
              <ItemTemplate>
                  
                  <asp:LinkButton ID="linkdownload" Text="DownLoad" CommandName="download" runat="server"  OnClick="linkdownload_Click">                 
                      </asp:LinkButton>
              </ItemTemplate>

           </asp:TemplateField>--%>
            <asp:CommandField ShowSelectButton="true" SelectText="Download" />
        </Columns>
    </asp:GridView>
 
</asp:Content>

