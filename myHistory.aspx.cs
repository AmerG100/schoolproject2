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

public partial class myHistory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
       


        if ((string)Session["username1"] != null)
        {
            string usr = (string)Session["username1"];
           
            int id2 = customers1.Get1customer(usr).GetIdcustomer();
           // int idDeal = Deals.GetorderidbyusrId(id2);
            

            DataSet dsOrders = Deals.GetAllOrdersByClient(id2);
            DataGrid1.DataSource = dsOrders;
            DataGrid1.DataBind();
            if (Request["orderId"] != null)
            {
                orderKoteret.Text = Deals.Get1Order(Request["orderId"]).ToString();
                DataSet ds = Deals.GetAllOrdersDetailsByOrderId(Request["orderId"]);
                DataGrid2.DataSource = ds;
                DataGrid2.DataBind();
                DataGrid2.Visible = true;
                Label2.Visible = true;
                Label3.Visible = true;

                Label3.Text = Deals.GetTotalOrder(Request["orderId"]).ToString();
            }
            else
            { DataGrid2.Visible = false; }

            Label1.Text = "..";
        }
        else
        {
            Label1.Text = "you have to login(or register) first !";
        }
    }
    protected string ConvertIdtoTotal(object orderId)
    {
        return Deals.GetTotalOrder(orderId+ "").ToString();
    }
}
