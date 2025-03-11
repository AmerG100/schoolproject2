<%@ Page Language="C#" MasterPageFile="~/MasterPage1.master" 
AutoEventWireup="true" CodeFile="adminlogin.aspx.cs" Inherits="adminlogin" 
Title="Untitled Page" %>



<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table><tr><td>user name</td><td>    <asp:TextBox ID="TextBox1" runat="server" Text="1"/></td>
      </tr>
      <tr><td>password</td><td><input id="Password1" type="password" name="Password1" /></td>
      </tr>
      <tr><td colspan="2"><asp:Label ID="Label1" runat="server" visible="False"
                              Text ="wrong password or username"></asp:Label></td>
     </tr>
     <tr><td colspan="2"><asp:Button ID="Button1" runat="server" 
                         Text="enter ADMIN state" OnClick="Button1_Click" /> </td>
     </tr>
</table>
</asp:Content>