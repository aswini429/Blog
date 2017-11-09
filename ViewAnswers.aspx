<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="ViewAnswers.aspx.cs" Inherits="ViewAnswers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Image ID="img1" runat="server" />
    <asp:GridView ID="gridanswers" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:TemplateField HeaderText="Question">
                <ItemTemplate><asp:Label ID="lblqu" runat="server" Text='<%#Eval("Question") %>'></asp:Label>
                   </ItemTemplate>

            </asp:TemplateField>
            <asp:TemplateField HeaderText="Answer">
                <ItemTemplate><%#Eval("Reply") %></ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PostedBy">
                <ItemTemplate><%#Eval("UserName") %></ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

</asp:Content>

