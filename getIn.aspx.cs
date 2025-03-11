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


public partial class getIn : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        DataSet ds = LoginC.GetAllUsersByUserName(TextBox1.Text);
        if (ds.Tables[0].Rows.Count != 1)
        {
            Label2.Text = "wrong,try again";
        }
        else
        {
            if (TextBox2.Text == ds.Tables[0].Rows[0]["password1"].ToString())
            {
                Session["username1"] = TextBox1.Text;
                Response.Redirect("type.aspx");
            }
        }
        
    }
}
