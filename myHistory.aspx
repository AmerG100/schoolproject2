<%@ Page Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" 
CodeFile="myHistory.aspx.cs" Inherits="myHistory" Title="" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div><table><tr><td>
    <asp:DataGrid ID="DataGrid1" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" 
        CellPadding="4">
    
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <SelectedItemStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <ItemStyle BackColor="White" ForeColor="#330099" />
    
    <Columns>
    <asp:BoundColumn HeaderText="#" DataField="id_deal"></asp:BoundColumn>
        <asp:TemplateColumn HeaderText="date">
            
            <ItemTemplate>
                <asp:Label runat="server" 
                    Text='<%# DataBinder.Eval(Container.DataItem,"deal_date","{0:d}") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateColumn>

    <asp:TemplateColumn HeaderText="cost" >
        <ItemTemplate>
         
          <asp:Label ID="Label6" runat="server" 
             Text='<%#ConvertIdtoTotal(DataBinder.Eval(Container.DataItem,"id_deal","{0}")) %>'
          />
       
          </ItemTemplate>
    </asp:TemplateColumn>

     
        <asp:TemplateColumn >
        
            <ItemTemplate>
            <a href="myhistory.aspx?orderId=<%# DataBinder.Eval(Container, "DataItem.id_deal") %>">
                <asp:Label runat="server" 
                    Text='look at order details'></asp:Label></a>
            </ItemTemplate>
        </asp:TemplateColumn>
   
    </Columns>
    
    
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
    
    
    </asp:DataGrid>
    </td><td valign="top">
    <asp:Label runat="server" 
                    ID="orderKoteret"/><br />
        <asp:Label ID="Label2" runat="server" Text="Cost :" Visible="False" Font-Bold="True" ForeColor="Green"></asp:Label>
        <asp:Label ID="Label3" runat="server" Visible="False"></asp:Label>
     <asp:DataGrid ID="DataGrid2" runat="server" AutoGenerateColumns="False"
     visible="False" width="299px" Height="114px">
     <Columns>
         <asp:TemplateColumn HeaderText="item">
             <ItemTemplate>
                 <asp:Label runat="server" 
                     Text='<%# products.GetItemDetailsById(DataBinder.Eval(Container,"DataItem.product")) %>'></asp:Label>
             </ItemTemplate>
             
         </asp:TemplateColumn>
     <asp:BoundColumn DataField="num_product" HeaderText="qty"/> 
     <asp:BoundColumn DataField="actual_price" HeaderText="price for each"/> 
     
     
     </Columns>
     
     
     </asp:DataGrid>
    
    </td></tr></table>
    <asp:Label ID="Label1" runat="server" Text="."></asp:Label>
    </div>
    <asp:Label ID="lbl1" runat="server"></asp:Label>
</asp:Content>
    
   
