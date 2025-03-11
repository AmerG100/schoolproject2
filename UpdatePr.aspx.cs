using System;
using System.Data.OleDb;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UpdatePr : System.Web.UI.Page
{
   
    Mproduct pr;
    

    protected void Page_Load(object sender, EventArgs e)
    {
        
        if (!IsPostBack)
        {
           string productId = Request.QueryString["id"];
            if (string.IsNullOrEmpty(productId))
            {
               
                return;
            }
            Mproduct pr2=products.Get1product(productId);
            TextBox1.Text = pr2.GetProductName();
            TextBox2.Text = pr2.GetPrice().ToString();
            TextBox3.Text = pr2.GetStock().ToString();
            Image1.ImageUrl = "../Images/" + pr2.GetPicture();
            DropDownList1.SelectedValue = pr2.GetProductType().ToString();
           
            CheckBox1.Checked = pr2.GetProductexist();



        }
        if (Page.IsPostBack)//it is ELSE,actually.it happens when we press the update or delete buttons
        {

           //string productId = Request.QueryString["id"];
           // int id = int.Parse(productId);

           // string name = ezerTables.ChgTheGersh(TextBox1.Text);



           // double price = double.Parse(TextBox2.Text);


           // int stock = int.Parse(TextBox3.Text);


           // int type = DropDownList1.SelectedIndex;




           // FileUpload fu = (FileUpload)FileUpload1;//טעינת התמונה
           // string strFileName = ezerTables.PictureCode(fu);//הכנסת התמונה הפיזית וחילוץ השם,דרך פעולת עזר

           // if (strFileName == "" || strFileName == null)//הבאת התמונה שלנו, שלא השתנתה 
           // {
           //     strFileName = Image1.ImageUrl.Substring(Image1.ImageUrl.LastIndexOf("/") + 1);
           // }
           // string picture = strFileName;
           // Mproduct pr = new Mproduct(id, type, name, stock, price, picture);

        }
    }

 

    protected void btnCancel_Click(object sender, EventArgs e)
    {

        Response.Redirect("DeletUpd.aspx");
    }

  

    protected void Button1_Click1(object sender, EventArgs e)
    {
        string productId = Request.QueryString["id"];
        int id = int.Parse(productId);

        string name = ezerTables.ChgTheGersh(TextBox1.Text);



        double price = double.Parse(TextBox2.Text);


        int stock = int.Parse(TextBox3.Text);


        int type = DropDownList1.SelectedIndex;
        bool exist = CheckBox1.Checked;




        FileUpload fu = (FileUpload)FileUpload1;//טעינת התמונה
        string strFileName = ezerTables.PictureCode(fu);//הכנסת התמונה הפיזית וחילוץ השם,דרך פעולת עזר

        if (strFileName == "" || strFileName == null)//הבאת התמונה שלנו, שלא השתנתה 
        {
            strFileName = Image1.ImageUrl.Substring(Image1.ImageUrl.LastIndexOf("/") + 1);
        }
        string picture = strFileName;
        Mproduct pr = new Mproduct(id, type, name, stock, price, picture,exist);
        products.Update1Product(pr);//ראה סוף פעולה קודמת
                                    // Response.Redirect("../users/teamsShow.aspx?idTeam=" + Label4.Text)
    }
}
