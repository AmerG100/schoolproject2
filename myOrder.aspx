<%@ Page Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" 
CodeFile="myOrder.aspx.cs" Inherits="myOrder" Title="" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br /><br />
    <asp:DataGrid ID="DataGrid1" runat="server" CellPadding="3"
        
        DataKeyField="ID" ShowFooter="True" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px">
        <FooterStyle BackColor="White" ForeColor="#000066" />
        <SelectedItemStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" 
            Mode="NumericPages" />
        <ItemStyle ForeColor="#000066" />
        <Columns>
            <asp:BoundColumn DataField="id" HeaderText="#" ReadOnly="True"></asp:BoundColumn>
            <asp:BoundColumn HeaderText="מוצר" ReadOnly="True" DataField="Product"></asp:BoundColumn>


   
            <asp:BoundColumn HeaderText="כמות" DataField="quantity"  ItemStyle-Width="10" ItemStyle-HorizontalAlign="Center">
<ItemStyle HorizontalAlign="Center" Width="10px"></ItemStyle>
            </asp:BoundColumn>

 
            <asp:BoundColumn HeaderText="מחיר" ReadOnly="True" DataField="cost"></asp:BoundColumn>
            <asp:BoundColumn HeaderText="סה&quot;כ " ReadOnly="True" DataField="RowTotal"></asp:BoundColumn>
 
 
 

          </Columns>
        <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
    </asp:DataGrid><br><br>

<asp:Label id=lblTotal runat="server" text="total:"/>

    <br />
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
        Text="CONFIRM ORDER" />

    </div>
</asp:Content>
    
   
