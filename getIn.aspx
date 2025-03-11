<%@ Page Language="C#" MasterPageFile="~/MasterPage1.master" AutoEventWireup="true" 
CodeFile="getIn.aspx.cs" Inherits="getIn" Title="" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 15px;
        }


        .auto-style2 {
            width: 1215px;
            height: 676px;
        }


    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<div class="auto-style2" style="background-image: none">
    welcome back to the supermarket shop
    <br />
    enter your user name and password<br />
    <br />
    user name&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    password&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <asp:ImageButton ID="ImageButton1" runat="server" Width="203px" ImageUrl="~/Images/loginnn.jpg" Height="57px" OnClick="ImageButton1_Click" CssClass="auto-style1" />
    <asp:Label ID="Label2" runat="server"></asp:Label>
    <br />
&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="."></asp:Label>
    </div>
</asp:Content>
    
   