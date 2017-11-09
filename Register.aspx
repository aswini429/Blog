<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    REGISTRATION PAGE:
   <table>
       <tr>
           <td>LoginId</td>
           <td><asp:Label ID="lblid" runat="server"></asp:Label></td>
       </tr>
       <tr>
           <td> Name</td>
           <td><asp:TextBox ID="txtname" runat="server"></asp:TextBox></td>
       
       </tr>
       <tr>
           <td>
               Username
           </td>
           <td><asp:TextBox ID="txtuname" runat="server"></asp:TextBox></td>
       </tr>
       <tr>
           <td>Password</td>
           <td><asp:TextBox ID="txtpwd" runat="server"></asp:TextBox></td>
       </tr>
       <tr>
           <td>Security</td>
           <td><asp:DropDownList ID="dropdownsecurity" runat="server">
               <asp:ListItem>
                   Wt is ur petname
               </asp:ListItem>
               <asp:ListItem>what is ur childhoodname</asp:ListItem>
               <asp:ListItem>What is ur favorite food</asp:ListItem>
               </asp:DropDownList></td>
           
       </tr>

       <tr>
           <td>Answer</td>
           <td><asp:TextBox ID="txtanswer" runat="server"></asp:TextBox></td>
       </tr>
       <tr>
           <%--<td>Status</td>--%>
           <td><asp:TextBox ID="txtstatus"  runat="server" Visible="false"></asp:TextBox ></td>
           
           
       </tr>
   </table>
    <asp:Button ID="btnsubmit" runat="server" Text="Submit" OnClick="btnsubmit_Click" />
    <asp:Label ID="lblmsg" runat="server" ></asp:Label>
</asp:Content>

