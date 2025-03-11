<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage1.master" 
AutoEventWireup="true" CodeFile="customers.aspx.cs" Inherits="customers" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  <div>
    <table><tr>
    <td>
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" 
            OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" 
            Height="113px" style="margin-top: 0px"></asp:ListBox></td>

    <td>

        <asp:DataGrid ID="DataGrid1" runat="server" 
            AutoGenerateColumns="False">
            <Columns>

                <asp:TemplateColumn HeaderText="name">
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" 
             Text='<%#ConvertIdToCustomerName(DataBinder.Eval(Container.DataItem,"customers","{0}")) %>'
          />
                </ItemTemplate>
            </asp:TemplateColumn>


                 <asp:TemplateColumn HeaderText="deal date">
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" 
             Text='<%#DataBinder.Eval(Container.DataItem,"deal_date","{0:d}") %>'
          />
                </ItemTemplate>
            </asp:TemplateColumn>

                 <asp:TemplateColumn HeaderText="deal employees">
                <ItemTemplate>
                    <asp:Label ID="Label6" runat="server" 
             Text='<%#ConvertIdToCustomerEmployees(DataBinder.Eval(Container.DataItem,"deal_employee","{0}")) %>'
          />
                </ItemTemplate>
            </asp:TemplateColumn>



            </Columns>
           
        </asp:DataGrid>
        </td>
        </tr>
        </table>

       
    
    
    
    
        <asp:Label ID="Label1" runat="server" Text="_"></asp:Label>
        <br /><asp:Label ID="Label2" runat="server" Text="_"></asp:Label><br />
        <asp:Label ID="Label3" runat="server" Text="_"></asp:Label>
    </div>


</asp:Content>

