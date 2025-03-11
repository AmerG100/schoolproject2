using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;




public partial class type : System.Web.UI.Page
{

    DataSet ds;
    protected void Page_Load(object sender, EventArgs e)
    {
        // DBConn = new DBConnection(Server.MapPath("~/App_Data/db.mdb"));
        //we dont need to build an object.
        //it is built in basis.cs

        if (!Page.IsPostBack)
        {//all at first time
            ListBox1.DataTextField = "type";// 
            ListBox1.DataValueField = "id_type";
            ListBox1.DataSource = usingClasses.GetAlltypes();
            ListBox1.DataBind();

            //  ds = DBConn.RunDataSetSQL("select * from type ");
            //DataGrid1.Visible = false;
            if (Session["username1"] != null)
            {
                Label1.Text = "welcome, " + Session["username1"];
                Label1.Visible = true;
            }
            else
                Label1.Visible = false;




        }



    }


    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Label1.Visible = false;

        int x = ListBox1.SelectedIndex; //4
        string whatCat = ListBox1.Items[x].Value;

        ShowtypeNameAndCDs(whatCat);



    }
    protected string ConvertIdToProductName(object productId)
    {
        return products.ConvertIdToProduct(productId + "");
    }
    protected string ConvertIdToPrice(object productId)
    {
        return products.ConvertIdToProduct1(productId + "");
    }





    protected void DataList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int x = ListBox1.SelectedIndex; //4
        string whatCat = ListBox1.Items[x].Value;

        ShowtypeNameAndCDs(whatCat);
    }
    protected void ShowtypeNameAndCDs(string catId)
    {
        Label3.Text = type1.GettypeNameById(catId);
        DataSet ds = usingClasses.ProductBy1type(catId);
        // DataGrid1.DataSource = ds;
        // DataGrid1.DataBind();
        DataList1.DataSource = ds;
        DataList1.DataBind();

        //if (ds.Tables[0].Rows.Count == 0)

        //    DataGrid1.Visible = false;
        //else
        //    DataGrid1.Visible = true;
    }
}