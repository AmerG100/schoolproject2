using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

public partial class myOrder : System.Web.UI.Page
{
    Cart crt;
    string usr;
    protected void Page_Load(object sender, EventArgs e)
    {
        if((Cart)Page.Session["Cart"]!=null)
        {
            crt = (Cart)Page.Session["Cart"];
            DataGrid1.DataSource = crt.GetDT();//.Columns[.;
            DataGrid1.DataBind();

            lblTotal.Text = "Total: " + crt.GetItemTotal();


            //client
            usr = (string)Page.Session["username1"];
            if (usr != null)
                Label1.Text = "פרטי הלקוח" + "<br/>" + customers1.Get1customer(usr).ToString();
            else
                Label1.Text = "no client !!!";
        }
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //get details of order ,create order-object and make an "add order"

        int user = customers1.Get1customer(usr).GetIdcustomer();
        DateTime dt = DateTime.Now.Date;
        int employe =1;
        int st = Deals.GetMaxOrderId();

        Deal ord = new Deal(st+1,user, dt,employe);
        Deals.Add1Order(ord);

        //get the lines of the cart,add each one to "details order"
        
        Deals.AddOrderDetails(st+1, crt.GetDT());
        crt.DeleteAllRows();   


        Response.Redirect("myHistory.aspx");
    }
}
