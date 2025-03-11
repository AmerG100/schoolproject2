<%@ Page Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" 
CodeFile="register.aspx.cs" Inherits="register" Title="" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div>
    <asp:Panel ID="panel1" runat=server> 
    <table>
    <tr><td>username</td><td>
        <asp:TextBox ID="TextBoxUser" runat="server"/></td></tr>
    <tr><td>
        &nbsp;</td><td>
            <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/Images/check.png" OnClick="ImageButton2_Click" Width="118px" />
        </td></tr>
    <tr><td>&nbsp</td><td>
        <asp:Label ID="Label1" runat="server"/></td></tr>

</table>
</asp:Panel> 

    <asp:Panel ID="panel2" runat="server" Visible="false"> 
    <table>
    <tr><td>username</td><td>
        <asp:TextBox ID="TextBox1" runat="server"/>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1">*</asp:RequiredFieldValidator>
        </td></tr>
        
        
        
    <tr><td>password</td><td>
        <asp:TextBox ID="TextBox2" runat="server"/>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2">*</asp:RequiredFieldValidator>
        </td></tr>
    <tr><td>first name</td><td>
        <asp:TextBox ID="TextBox3" runat="server"/>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3">*</asp:RequiredFieldValidator>
        </td></tr>
    <tr><td>last name</td><td>
        <asp:TextBox ID="TextBox4" runat="server"/>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4">*</asp:RequiredFieldValidator>
        </td></tr>
    <tr><td>gender&nbsp;</td>
        <td>
   
        <asp:TextBox ID="TextBox5" runat="server"/>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TextBox5">*</asp:RequiredFieldValidator>
        </td></tr>
    
    <tr><td>phone</td><td>
        <asp:TextBox ID="TextBox6" runat="server"/>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TextBox6">*</asp:RequiredFieldValidator>
        </td></tr>
    <tr><td>&nbsp;</td><td>
        <asp:ImageButton ID="ImageButton4" runat="server" Height="38px" ImageUrl="~/Images/registerrr.jpg" OnClick="ImageButton1_Click" Width="135px" />
        </td></tr>
     <tr><td>&nbsp;</td><td>
         &nbsp;</td></tr>
    
    </table>
        
   </asp:Panel>     
    </div>
</asp:Content>
    
   
