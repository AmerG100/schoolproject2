<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" 
AutoEventWireup="true" CodeFile="employees.aspx.cs" Inherits="employees" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div>
    <table><tr>
    <td>
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" 
            OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" 
            Height="113px" style="margin-top: 0px"></asp:ListBox></td>
    <td valign=top>
        <asp:DataGrid ID="DataGrid1" runat="server">
        </asp:DataGrid>

        <asp:Label ID="Label4" runat="server" Text="--"></asp:Label></td>
    </tr></table>
      
    
    
    
    
    
        <asp:Label ID="Label1" runat="server" Text="_"></asp:Label>
        <br /><asp:Label ID="Label2" runat="server" Text="_"></asp:Label><br />
        <asp:Label ID="Label3" runat="server" Text="_"></asp:Label>
    </div>


</asp:Content>

