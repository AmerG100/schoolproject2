using System;
using System.Data;         //!!!!!
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.OleDb;   //!!!!!

 
public partial class Default3 : System.Web.UI.Page 
{
    DBConnection DBConn;  //"recognized" by all functions 

    protected void Page_Load(object sender, EventArgs e)
    {
       // DBConn = new DBConnection(  Server.MapPath("~/App_Data/db.mdb")  );
        
        
        
        DanniLabel2.Text = Server.MapPath("~/App_Data/db.mdb");
        DataSet ds = usingClasses.GetAllCustomers(); 
            //DBConn.RunDataSetSQL("select * from Customers ");
                        //connection-->command-->adapter---->DataSet
        // NOW THERE IS A DATASET
string output="";
        for (int i = 0; i < ds.Tables[0].Rows.Count; i++) //6
        {       //i --> number of the row
            output = output +
                ds.Tables[0].Rows[i][0] +    " , "+      
                 ds.Tables[0].Rows[i][1] + " , "+ //7
                 ds.Tables[0].Rows[i][2]+"<br/>";
        
        }
        Label1.Text= output;
  
        ListBox1.DataSource = ds;//ForListBox



        ListBox1.DataTextField = "Name";
        ListBox1.DataValueField = "CustomerID";

        ListBox1.DataBind();
    }
}