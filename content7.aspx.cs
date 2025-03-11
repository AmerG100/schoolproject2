using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

    public partial class content7 : System.Web.UI.Page
{
    
    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
       // DBConn = new DBConnection(Server.MapPath("~/App_Data/db.mdb"));
//we dont need to build an object.
//it is built in basis.cs

        if (!Page.IsPostBack)
        {//all at first time
            ListBox1.DataTextField = "Name";// 
            ListBox1.DataValueField = "id_customers";
            ListBox1.DataSource = usingClasses.GetAllCustomersSORTED();
            ListBox1.DataBind();

           // ds = DBConn.RunDataSetSQL("select * from purchases ");
            DataGrid1.Visible = false;




        }
         

       
    }


    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Label1.Visible = false;
        Label2.Text = ListBox1.SelectedIndex + " index(selected) in listBox 0,1,2,..";
        Label3.Text = ListBox1.Items[ListBox1.SelectedIndex].Value + " customerId,actually(look at detail table";

        ds = usingClasses.PurchasesBy1Customer(ListBox1.Items[ListBox1.SelectedIndex].Value); 
        DataGrid1.DataSource = ds;
        DataGrid1.DataBind();
        //
        if (ds.Tables[0].Rows.Count == 0)
        {
            //     if (((DataSet)DataGrid1.DataSource).Tables[0].Rows.Count == 0) //alternatively
            DataGrid1.Visible = false;
            Label4.Text = "no kniot yet";
            Label4.Visible = true;
        }
        else
        {
            DataGrid1.Visible = true;
           // Label4.Text = "yofi!!!";
            Label4.Visible = false;
        }

    }
 
}