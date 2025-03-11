using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;

 
public partial class Default4 : System.Web.UI.Page 
{
   // DBConnection DBConn;  //"recognized" by all functions in final

    protected void Page_Load(object sender, EventArgs e)
    {
        ListBox1.DataSource = usingClasses.GetAllCustomers();
             
        ListBox1.DataTextField = "Name";
        ListBox1.DataValueField = "CustomerID";
       
        ListBox1.DataBind();


      DataSet ds1 =usingClasses.GetAllCustomers();
       DataGrid1.DataSource = ds1;// ListBox1.DataSource;
        
        DataGrid1.DataBind();




        DataGrid2.DataSource = ds1;// ListBox1.DataSource;
        DataGrid2.DataBind();

        DataGrid3.DataSource = ds1;// ListBox1.DataSource;
        DataGrid3.DataBind();

    }
}