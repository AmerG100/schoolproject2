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

public partial class myCart : System.Web.UI.Page
{
    //   System.Data.DataTable  objDT ; 
    //   System.Data.DataRow objDR ;

    Cart crt;
    string xName, yKamut, zPrice, itemId;// 
    string idProd, idProdPlus, idProdMinus;
    protected void Page_Load(Object sender, EventArgs e)
    {
        if (Session["username1"] == null)
        {
            lbl10.Text = "you need to login first";
            Button1.Visible = false;
            lblTotal.Visible = false;
            Image10.Visible = false;
           
        }
        else
        {
            
          
                crt = (Cart)Page.Session["Cart"];

                idProd = Request["idProd"];
                idProdMinus = Request["idProdMinus"];
                idProdPlus = Request["idProdPlus"];
                if (idProd != null)
                {
                    crt.DeleteByIdProd(idProd);
                    idProd = null;
                }
                if (idProdPlus != null)
                    crt.UpdateByIdProd(idProdPlus, "+");
                if (idProdMinus != null)
                    crt.UpdateByIdProd(idProdMinus, "-");

                itemId = Request["item"];
                
                if (itemId != null)   
                {
                    xName = products.Get1product(itemId).GetProductName();
                    yKamut = "1";
                    zPrice = products.Get1product(itemId).GetPrice().ToString();

                    crt = (Cart)Page.Session["Cart"];
                    if (crt == null)
                    {
                        crt = new Cart(itemId);
                        Page.Session["Cart"] = crt;
                    }


                    crt.AddToCart(itemId, xName, yKamut, zPrice);
                    DataGrid1.Visible = true;
                    lblTotal.Visible = true;


                  
                }
               
            crt = (Cart)Page.Session["Cart"];//
            DataGrid1.DataSource = crt.GetDT();//
            DataGrid1.DataBind();//

            lblTotal.Text = "Total: " + crt.GetItemTotal();//









        }
        



    }



    protected void Button1_Click(object sender, EventArgs e)
    {

        crt = (Cart)Page.Session["Cart"];
        crt.EmptyTheDTofCart();
        //DataGrid1.DataSource = crt.GetDT();//.Columns[.;
        //DataGrid1.DataBind();
        DataGrid1.Visible = false;
        lblTotal.Visible = false;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        crt = (Cart)Page.Session["Cart"];
        Response.Redirect("myOrder.aspx");
    }
}
