<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage3.master" AutoEventWireup="true" CodeFile="Usersadmin.aspx.cs" Inherits="Usersadmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="gridusers" runat="server" AutoGenerateColumns="false" OnRowCommand="gridusers_RowCommand">
        <Columns>
            <asp:TemplateField HeaderText="LoginId">
                <ItemTemplate><asp:Label ID="lblid" runat="server" Text='<%#Eval("LoginId") %>'></asp:Label></ItemTemplate>
            </asp:TemplateField>
             <asp:TemplateField HeaderText="Name">
                <ItemTemplate>
                    <asp:Label ID="lblname" runat="server" Text='<%#Eval("Name") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="UserName">
                <ItemTemplate>
                    <asp:Label ID="lbluname" runat="server" Text='<%#Eval("UserName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="SecretQuestions">
                <ItemTemplate>
                    <asp:Label ID="lblsecret" runat="server" Text='<%#Eval("SecQuestion") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Answer">
                <ItemTemplate>
                    <asp:Label ID="lblanswer" runat="server" Text='<%#Eval("Answer") %>' ></asp:Label></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Status">
                <ItemTemplate>
                    <asp:LinkButton ID="linkstatus" runat="server" Text='<%#Eval("Status") %>'></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>

