<%@ Page Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" 
CodeFile="myCart.aspx.cs" Inherits="myCart" Title="Untitled Page" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
 <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            Text="EMPTY THE CART" />
          <a href="myOrder.aspx">  <asp:Image ID="Image10" runat="server" Height="29px" Width="121px" ImageUrl="~/Images/checkout.jpg" /></a>
 <asp:DataGrid ID="DataGrid1" runat="server" CellPadding="4" ForeColor="#333333"
        
        DataKeyField="ID" 


        
        GridLines="None" ShowFooter="True" AutoGenerateColumns="false">
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <EditItemStyle BackColor="#2461BF" />
        <SelectedItemStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <AlternatingItemStyle BackColor="White" />
        <ItemStyle BackColor="#EFF3FB" />
        <Columns>
            <asp:BoundColumn DataField="ID" HeaderText="#" ReadOnly="True"></asp:BoundColumn>
            <asp:BoundColumn HeaderText="מוצר" ReadOnly="True" DataField="Product"></asp:BoundColumn>


 <asp:TemplateColumn >
           <ItemTemplate> 
             <a href="mycart.aspx?idProdMinus=<%# DataBinder.Eval(Container,"DataItem.ID") %>">
             <img src="../gifs/minus.gif" border=0 width=10/>
             
             </a>
           </ItemTemplate>
          </asp:TemplateColumn>   
            <asp:BoundColumn HeaderText="כמות" DataField="quantity"  ItemStyle-Width="10" ItemStyle-HorizontalAlign="Center"></asp:BoundColumn>
<asp:TemplateColumn >
           <ItemTemplate> 
             <a href="mycart.aspx?idProdPlus=<%# DataBinder.Eval(Container,"DataItem.ID") %>">
             <img src="../gifs/plus.gif" border=0  width=10/>
             
             </a>
           </ItemTemplate>
          </asp:TemplateColumn> 
 
            <asp:BoundColumn HeaderText="מחיר" ReadOnly="True" DataField="cost"></asp:BoundColumn>
            <asp:BoundColumn HeaderText="סה&quot;כ " ReadOnly="True" DataField="RowTotal"></asp:BoundColumn>
 <asp:HyperLinkColumn Text="remove"
  
            DataNavigateUrlField="Id" 
            DataNavigateUrlFormatString="myCart.aspx?idProd={0}"
 />
 
 

          </Columns>
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    </asp:DataGrid>
    <asp:Label ID="lbl10" runat="server"></asp:Label>
    <br><br>

<asp:Label id=lblTotal runat="server" text="total:"/>

    <br />   <input onclick="history.back()" type="button" value="Back" /><br />

</asp:Content>