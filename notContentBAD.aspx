<%@ Page Language="C#" AutoEventWireup="true"  
CodeFile="notContentBAD.aspx.cs" Inherits="Default4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox> 
        <br />
        <asp:DataGrid ID="DataGrid1" runat="server">
        </asp:DataGrid>



        <asp:Panel ID="Panel1" runat="server" Visible=true>
       
        <asp:DataGrid ID="DataGrid2" runat="server" CellPadding="4" ForeColor="#333333" 
            GridLines="None">
            <AlternatingItemStyle BackColor="White" />
            <FooterStyle BackColor="#990000" ForeColor="White" Font-Bold="True" />
            <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <ItemStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        </asp:DataGrid>
        
        <asp:DataGrid ID="DataGrid3" runat="server" CellPadding="3" 
            GridLines="Horizontal" BackColor="yellow" BorderColor="#E7E7FF" BorderStyle="None" 
            BorderWidth="1px">
            <FooterStyle BackColor="red" ForeColor="#4A3C8C" />
            <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" 
                Mode="NumericPages" />
            <AlternatingItemStyle BackColor="red" />
            <ItemStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        </asp:DataGrid>
         </asp:Panel>
       
        </div>
    </form>
</body>
</html>
