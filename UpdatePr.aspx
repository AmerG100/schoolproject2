<%@ Page Title="Update Product" Language="C#" MasterPageFile="~/MasterPage1.master" 
AutoEventWireup="true" CodeFile="UpdatePr.aspx.cs" Inherits="UpdatePr" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h2>Update Product</h2>
    <table>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Stock"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Picture"></asp:Label>
            </td>
            <td>
                <asp:Image ID="Image1" runat="server" Width="33px" />
            </td>
            <td>
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Type"></asp:Label>
            </td>
            <td>
                &nbsp;</td>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server">
                    <asp:ListItem Selected="True">Choose Type</asp:ListItem>
                    <asp:ListItem Value="1">meat</asp:ListItem>
                    <asp:ListItem Value="2">drinks</asp:ListItem>
                    <asp:ListItem Value="3">snacks</asp:ListItem>
                    <asp:ListItem Value="4">bakery</asp:ListItem>
                    <asp:ListItem Value="5">fruit and veg</asp:ListItem>
                    <asp:ListItem Value="6">dairy product</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                exist ?</td>
            <td>
                &nbsp;</td>
            <td>
                <asp:CheckBox ID="CheckBox1" runat="server" />
            </td>
        </tr>
    </table>

    <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
    <asp:Button ID="Button1" runat="server" Font-Bold="True" OnClick="Button1_Click1" Text="Update" />
</asp:Content>
