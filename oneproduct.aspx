<%@ Page Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" 
CodeFile="oneproduct.aspx.cs" Inherits="oneproduct" Title="Untitled Page" %>




<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    Product details<br />

    <br />
      <table>
      <tr><td>product_code </td><td><asp:Label ID="Label4" runat="server" Text="Label"/></td>
    <td>
        <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/add.jpg" OnClick="ImageButton1_Click" Width="148px" />
        <br />
        note that you have to login/register first!
                                    </td>  </tr>
          <tr>
              <td>product_name </td>
              <td>
                  <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label></td>
      
       <td>
       </td> 
            </tr>
          <tr>
              <td>product_type </td>
              <td>
                  <asp:Label ID="Label6" runat="server"></asp:Label>&nbsp;<asp:Label runat="server" id="LabelCat0"
            Text=""
            />
                 </td>
        <td>
         </td> 

          </tr>
          <tr>
              <td>&nbsp;<asp:Label ID="Label8" runat="server" Text="stock" Visible="False"></asp:Label>
              </td>
              <td>
                 <asp:Label ID="Label7" runat="server"></asp:Label>
               
         </td>
         <td>
               
         </td>
          </tr>       
 <tr>
              <td>picture</td>
              <td>

<asp:Image ID="Image1" runat="server" ImageUrl="" Height="55px" />
                  <asp:Label ID="Label1" runat="server" Text="Label"
                  visible="false"></asp:Label>
                  </td>
        <td>
         </td> 

          </tr>   
          
                    <tr>
              <td>price</td>
              <td>

                 <asp:Label ID="LabelPrice" runat="server"  >
                 </asp:Label>
               
         </td>
         <td>
               
         </td>
          </tr>  

</table>     
    <br />   <input onclick="history.back()" type="button" value="Back" /><br />
 


</asp:Content>

