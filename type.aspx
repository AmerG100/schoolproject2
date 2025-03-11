<%@ Page Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" 
CodeFile="type.aspx.cs" Inherits="type" Title="Product Categories" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
        body {
            font-family: 'Roboto', sans-serif;
            background-color: #f9f9f9;
            color: #333;
        }
        .product-container {
            display: flex;
            flex-wrap: wrap;
            gap: 20px;
            padding: 20px;
        }
        .product-card {
            background: #fff;
            border: 1px solid #ddd;
            border-radius: 8px;
            padding: 15px;
            width: 180px;
            text-align: center;
            box-shadow: 0 2px 5px rgba(0,0,0,0.1);
            transition: transform 0.3s ease;
        }
        .product-card:hover {
            transform: translateY(-5px);
            box-shadow: 0 4px 10px rgba(0,0,0,0.2);
        }
        .product-image {
            max-width: 100%;
            height: auto;
            border-radius: 8px;
        }
        .product-name {
            font-size: 16px;
            font-weight: bold;
            margin: 10px 0;
            color: #555;
        }
        .list-box {
            width: 200px;
            padding: 10px;
            border: 1px solid #ddd;
            border-radius: 8px;
            background-color: #fff;
        }
        .label {
            font-size: 18px;
            font-weight: bold;
            color: #333;
            margin-bottom: 20px;
        }
        .status-label {
            font-size: 14px;
            color: #ff0000; 
            margin-top: 10px;
            display: none; 
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="product-container">
        <!-- Reintegrated Label1 -->
        <asp:Label ID="Label1" runat="server" CssClass="status-label"></asp:Label>

        <div class="list-box-container">
            <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" 
                OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" CssClass="list-box" />
        </div>
        <div class="product-list">
            <asp:Label ID="Label3" runat="server" CssClass="label"></asp:Label>
            <asp:DataList ID="DataList1" runat="server" RepeatColumns="5" CellSpacing="2" CellPadding="2" 
                ItemStyle-Width="160" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
                <ItemTemplate>
                    <div class="product-card">
                        <a href="oneproduct.aspx?idpr=<%# DataBinder.Eval(Container,"DataItem.product_code") %>">
                            <asp:Image ID="Image1" runat="server" CssClass="product-image"
                                ImageUrl='<%# DataBinder.Eval(Container.DataItem,"picture","../Images/{0}") %>' />
                            <asp:Label runat="server" ID="ttl" CssClass="product-name"
                                Text='<%# DataBinder.Eval(Container,"DataItem.product_name") %>' />
                        </a>
                    </div>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </div>
</asp:Content>