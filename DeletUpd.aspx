<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" 
AutoEventWireup="true" CodeFile="DeletUpd.aspx.cs" Inherits="DeletUpd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <h2>Select Product Type</h2>
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" 
            OnSelectedIndexChanged="ListBox1_SelectedIndexChanged"
            Height="113px"></asp:ListBox>
    </div>

    <br />

    <!-- Two columns: Existing Products (Left) | Non-Existing Products (Right) -->
    <div style="display: flex; justify-content: space-between; gap: 20px;">
        <!-- Existing Products -->
        <div style="width: 50%;">
            <h2>Existing Products</h2>
            <asp:DataGrid ID="DataGridExists" runat="server" AutoGenerateColumns="False" Visible="False">
                <Columns>
                    <asp:TemplateColumn HeaderText="Product Name">
                        <ItemTemplate>
                            <a href="oneproductAdmin.aspx?idpr=<%# Eval("product_code") %>">
                                <asp:Label runat="server" ID="lblName" Text='<%# Eval("product_name") %>' />
                            </a>
                        </ItemTemplate>
                    </asp:TemplateColumn>

                    <asp:TemplateColumn HeaderText="Image">
                        <ItemTemplate>
                            <asp:Image ID="img1" runat="server" Width="40"
                              ImageUrl='<%# Eval("picture", "~/Images/{0}") %>' />
                        </ItemTemplate>
                    </asp:TemplateColumn>

                    <asp:TemplateColumn HeaderText="Price">
                        <ItemTemplate>
                            <asp:Label ID="lblPrice" runat="server" 
                              Text='<%# ConvertIdToPrice(Eval("product_code")) %>' />
                        </ItemTemplate>
                    </asp:TemplateColumn>

                    <asp:TemplateColumn HeaderText="Exists">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkExist" runat="server" Checked="true" Enabled="false" />
                        </ItemTemplate>
                    </asp:TemplateColumn>

                    <asp:TemplateColumn HeaderText="Actions">
                        <ItemTemplate>
                            <asp:Button ID="btnUpdate" runat="server" Text="Update"
                                CommandName="UpdateProduct" CommandArgument='<%# Eval("product_code") %>'
                                OnCommand="ProductCommand_Click" />

                            <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="delete-btn"
                                CommandName="DeleteProduct" CommandArgument='<%# Eval("product_code") %>'
                                OnCommand="ProductCommand_Click" />
                        </ItemTemplate>
                    </asp:TemplateColumn>
                </Columns>
            </asp:DataGrid>
        </div>

        <!-- Non-Existing Products -->
        <div style="width: 50%;">
            <h2>Non-Show Products</h2>
            <asp:DataGrid ID="DataGridNotExists" runat="server" AutoGenerateColumns="False" Visible="False">
                <Columns>
                    <asp:TemplateColumn HeaderText="Product Name">
                        <ItemTemplate>
                            <a href="oneproductAdmin.aspx?idpr=<%# Eval("product_code") %>">
                                <asp:Label runat="server" ID="lblName" Text='<%# Eval("product_name") %>' />
                            </a>
                        </ItemTemplate>
                    </asp:TemplateColumn>

                    <asp:TemplateColumn HeaderText="Image">
                        <ItemTemplate>
                            <asp:Image ID="img1" runat="server" Width="40"
                              ImageUrl='<%# Eval("picture", "~/Images/{0}") %>' />
                        </ItemTemplate>
                    </asp:TemplateColumn>

                    <asp:TemplateColumn HeaderText="Price">
                        <ItemTemplate>
                            <asp:Label ID="lblPrice" runat="server" 
                              Text='<%# ConvertIdToPrice(Eval("product_code")) %>' />
                        </ItemTemplate>
                    </asp:TemplateColumn>

                    <asp:TemplateColumn HeaderText="Exists">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkExist" runat="server" Checked="false" Enabled="false" />
                        </ItemTemplate>
                    </asp:TemplateColumn>

                    <asp:TemplateColumn HeaderText="Actions">
                        <ItemTemplate>
                            <asp:Button ID="btnUpdate" runat="server" Text="Update"
                                CommandName="UpdateProduct" CommandArgument='<%# Eval("product_code") %>'
                                OnCommand="ProductCommand_Click" />

                            <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="delete-btn"
                                CommandName="DeleteProduct" CommandArgument='<%# Eval("product_code") %>'
                                OnCommand="ProductCommand_Click" />
                        </ItemTemplate>
                    </asp:TemplateColumn>
                </Columns>
            </asp:DataGrid>
        </div>
    </div>

    <asp:Label ID="Label1" runat="server" Text="_"></asp:Label>
    <asp:Label ID="lblName" runat="server"></asp:Label>
</asp:Content>
