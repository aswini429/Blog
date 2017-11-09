<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage2.master" AutoEventWireup="true" CodeFile="ViewAllQuestions.aspx.cs" Inherits="ViewAllQuestions" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Image ID="image1" runat="server" />
    <asp:GridView ID="GridForums" runat="server" AutoGenerateSelectButton="true" AutoGenerateColumns="false" OnSelectedIndexChanging="gridforums_SelectedIndexChanging">
        <Columns>
            <asp:TemplateField HeaderText="ID" Visible="false">
                <ItemTemplate>
                    <asp:Label ID="lblQuestionId" runat="server" Text='<%#Eval("QuestionId") %>'> </asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Question">
                <ItemTemplate>
                    <asp:Label ID="lblQuestion" Text=' <%#Eval("Question") %>' runat="server"></asp:Label>
 </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PostedBy">
                <ItemTemplate>
                    <asp:Label ID="lblUserName" runat="server" ></asp:Label>
                   <%#Eval("UserName") %>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        </asp:GridView>
</asp:Content>

