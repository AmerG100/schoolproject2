using System;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class adminlogin : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request["what"] == "logoff")
        {
            Session["mutar"] = "";
            Response.Redirect("../default.aspx");
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (LoginC.NumOfOk(TextBox1.Text, Request["Password1"]) == 1)
        {
            Session["mutar"] = "ok";   // חשוב! זה ילווה אותנו כל הזמן...
            Label1.Visible = false;
        }
        else
        {
            Label1.Visible = true;
        }

        if ((string)Session["mutar"] == "ok") Response.Redirect("../default.aspx");
    }

}
