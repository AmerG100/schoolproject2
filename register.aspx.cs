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

public partial class register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   


    

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        
       
        string user = TextBox1.Text;
        string pass = TextBox2.Text;
        string fn = TextBox3.Text;
        string ln = TextBox4.Text;
        string gen = TextBox5.Text;
        string phone = TextBox6.Text;

        //int id = int.Parse(TextBox7.Text);

        Mcustomer newCl = new Mcustomer( fn, ln, user, gen, phone, pass);
        customers1.Add1Client(newCl);



        Response.Redirect("getIn.aspx");
    }

    protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
    {
        if (TextBoxUser.Text.Length==0)
            Label1.Text = "enter username";
        else
        {
            DataSet ds = LoginC.GetAllUsersByUserName(TextBoxUser.Text);
            if (ds.Tables[0].Rows.Count > 0)
            {
                Label1.Text = "wrong,try another username";
            }
            else
            {

                panel2.Visible = true;
                TextBox1.Text = TextBoxUser.Text;
                panel1.Visible = false;

            }
        }
      
    }
}
