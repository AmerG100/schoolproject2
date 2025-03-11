<%@ Page Language="C#" MasterPageFile="~/MasterPage1.master" 
AutoEventWireup="true" CodeFile="AdminSearchDeals.aspx.cs" 
Inherits="AdminSearchDeals" Title="Search Deals" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Search Deals</h2>

    <table>
        <tr>
            <td><label>Deal ID:</label></td>
            <td><asp:TextBox ID="txtDealID" runat="server"></asp:TextBox></td>

            <td><label>Customer Name:</label></td>
            <td><asp:TextBox ID="txtCustomerName" runat="server"></asp:TextBox></td>
        </tr>

        <tr>
            <td><label>From Date:</label></td>
            <td><asp:TextBox ID="txtFromDate" runat="server"></asp:TextBox></td>

            <td><label>To Date:</label></td>
            <td><asp:TextBox ID="txtToDate" runat="server"></asp:TextBox></td>
        </tr>

        <tr>
            <td colspan="2">
                <asp:Calendar ID="calFromDate" runat="server" OnSelectionChanged="calFromDate_SelectionChanged"></asp:Calendar>
            </td>
            <td colspan="2">
                <asp:Calendar ID="calToDate" runat="server" OnSelectionChanged="calToDate_SelectionChanged"></asp:Calendar>
            </td>
        </tr>
    </table>

    <br />

    <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
    <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>

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
                    <asp:Label runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"deal_date","{0:d}") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateColumn>

            <asp:TemplateColumn HeaderText="cost">
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" 
                        Text='<%# ConvertIdtoTotal(DataBinder.Eval(Container.DataItem,"id_deal","{0}")) %>' />
                </ItemTemplate>
            </asp:TemplateColumn>

            <asp:TemplateColumn>
                <ItemTemplate>
                    <a href="AdminSearchDeals.aspx?orderId=<%# DataBinder.Eval(Container, "DataItem.id_deal") %>">
                        <asp:Label runat="server" Text='look at order details'></asp:Label>
                    </a>
                </ItemTemplate>
            </asp:TemplateColumn>
        </Columns>
    
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
    </asp:DataGrid>

    <asp:DataGrid ID="DataGrid2" runat="server" AutoGenerateColumns="False" 
        Visible="False" Width="299px" Height="114px">
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

</asp:Content>
