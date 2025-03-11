using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using System.IO;           //file upload

public partial class _1productADD : System.Web.UI.Page
{
    Mproduct pro;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["mutar"]=="")
        {
            Response.Redirect("../default.aspx");
        }
        else
        {
            pro = new Mproduct();
            if ((string)Session["mutar"] != "ok")
                Response.Redirect("../users/getIn.aspx");

            if (!Page.IsPostBack)
            {

                int id = products.GetMaxproductId() + 1;
                Label2.Text = "(" + id.ToString() + ")";

            }
        }
        


    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        string nm = ezerTables.ChgTheGersh(TextBox1.Text);
        int type = int.Parse(ListBox1.SelectedItem.Value);
        int stock = int.Parse(TextBox2.Text);
        double price = double.Parse(TextBox3.Text);
        int id = 0;
        bool exist = false;
        if (stock > 0)
            exist = true;
        

        //-------------------------------

        //pictures


        FileUpload fu = (FileUpload)FileUpload1;
        //Has the file been uploaded properly?


        string strFileName = ezerTables.PictureCode(fu);
        //-------------------------------
        string pic = strFileName;
      
        Mproduct pro2 = new Mproduct(id, type, nm, stock, price, pic,exist);
        //
        



        products.Add1Product(pro2);





        Response.Redirect("../users/oneproduct.aspx?idpr=" + id);
       


    }

}
