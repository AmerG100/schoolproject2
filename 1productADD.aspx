<%@ Page Language="C#" MasterPageFile="~/MasterPage1.master" 
AutoEventWireup="true" CodeFile="1productADD.aspx.cs" Inherits="_1productADD " Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

     adding a product<br />
     
    <table>
      <tr><td>product code&nbsp;</td><td>
          <asp:Label ID="Label2" runat="server"></asp:Label>
          </td></tr>
      <tr><td>product name</td><td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
           <asp:RequiredFieldValidator id="val1"
            EnableClientScript = "true"
            ControlToValidate="TextBox1"
            Text="** Required Field"
            ForeColor="red"
            BackColor="white"
            runat="server"/>
                     </td>
      </tr>
      <tr><td>product type</td><td>
          <asp:ListBox ID="ListBox1" runat="server">
              <asp:ListItem Selected="True">choose type</asp:ListItem>
              <asp:ListItem Value="1">meat</asp:ListItem>
              <asp:ListItem Value="4">bakery</asp:ListItem>
              <asp:ListItem Value="2">drinks</asp:ListItem>
              <asp:ListItem Value="3">snacks</asp:ListItem>
              <asp:ListItem Value="5">fruit and veg</asp:ListItem>
              <asp:ListItem Value="6">dairy product</asp:ListItem>
          </asp:ListBox>
           <asp:RequiredFieldValidator id="RequiredFieldValidator1"
            EnableClientScript = "true"
            ControlToValidate="TextBox2"
            Text="** Required Field"
            ForeColor="red"
            BackColor="white"
            runat="server"/>

          </td>
             
      </tr>
      <tr><td>stock</td><td>
          <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
          </td>
      </tr>       
      <tr><td>price</td><td>
          <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
          </td>
     </tr> 
     <tr><td>picture</td><td><asp:FileUpload ID="FileUpload1" runat="server" /> 
         </td>
     </tr>                    
     <tr> <td>&nbsp;</td>
          <td>
                  &nbsp;</td>
    </tr>         
    <tr>
       <td>&nbsp;</td> <td> &nbsp; 
             </td>
    </tr>                    
    <tr><td>&nbsp;</td>
        <td>&nbsp;</td> 
    </tr>
    <tr><td colspan="2"><hr /></td>
    </tr>
    <tr><td> <br/>
            &nbsp;</td>
   </tr>
</table>
    
    <asp:Button ID="Button1" runat="server" Text="add this product" OnClick="Button1_Click" /><br />   <input onclick="history.back()" type="button" value="Back" /><br />
 
</asp:Content>

