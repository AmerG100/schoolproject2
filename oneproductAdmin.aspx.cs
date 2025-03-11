using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class oneproductAdmin : System.Web.UI.Page
{
    Mproduct pr1;
    protected void Page_Load(object sender, EventArgs e)
    {
        
        string prId = Request["idpr"];
        pr1 = products.Get1product(prId);
        if (!Page.IsPostBack)
        {
            Label4.Text = pr1.GetProductCode().ToString();
            Label5.Text = pr1.GetProductName();
            //Label6.Text = pr1.GetProductType();
            Label7.Visible = false;
            Label7.Text = pr1.GetStock().ToString();
            if(Session["mutar"] == "ok")
            {
                Label7.Visible = true;
                Label8.Visible = true;
            }
            Image1.ImageUrl = "../images/" + pr1.GetPicture();

            Label6.Text = products.GettypeNameById(pr1.GetProductType()).ToString();



            LabelPrice.Text = pr1.GetPrice().ToString();
        }

    }
    

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (Session["username1"] == null)
        {
            Response.Redirect("getIn.aspx");

        }
        else
        {
            Response.Redirect("myCart.aspx?item=" + Label4.Text);//catNum
        }
       
    }
}
