using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class DeletUpd : System.Web.UI.Page
{
    DataSet ds;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Ensure session check is valid and not null
        if (Session["mutar"] == null || Session["mutar"].ToString() == "")
        {
            Response.Redirect("../default.aspx");
        }
        else
        {
            if (!Page.IsPostBack)
            {
                // Populate ListBox with product types
                ListBox1.DataTextField = "type";
                ListBox1.DataValueField = "id_type";
                ListBox1.DataSource = type1.GetAlltypes();
                ListBox1.DataBind();

                // Hide DataGrids initially
                DataGridExists.Visible = false;
                DataGridNotExists.Visible = false;

                // Welcome message if username exists in session
               
            }
        }
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        

        // Fetch products of the selected type
        ds = type1.ProductBy1type(ListBox1.SelectedValue);

        // Split dataset into existing and non-existing products
        DataTable dtExists = ds.Tables[0].Clone();
        DataTable dtNotExists = ds.Tables[0].Clone();

        foreach (DataRow row in ds.Tables[0].Rows)
        {
            if (Convert.ToBoolean(row["exist"]))
                dtExists.ImportRow(row);
            else
                dtNotExists.ImportRow(row);
        }

        // Bind existing products
        DataGridExists.DataSource = dtExists;
        DataGridExists.DataBind();
        DataGridExists.Visible = dtExists.Rows.Count > 0;

        // Bind non-existing products
        DataGridNotExists.DataSource = dtNotExists;
        DataGridNotExists.DataBind();
        DataGridNotExists.Visible = dtNotExists.Rows.Count > 0;
    }

    protected string ConvertIdToPrice(object productId)
    {
        return products.ConvertIdToProduct1(productId.ToString());
    }

    protected void ProductCommand_Click(object sender, CommandEventArgs e)
    {
        string product_code = e.CommandArgument.ToString();

        if (e.CommandName == "UpdateProduct")
        {
            // Redirect to update product page with product ID
            Response.Redirect("UpdatePr.aspx?id=" + product_code);
        }
        else if (e.CommandName == "DeleteProduct")
        {
            DeleteProduct(int.Parse(product_code));
        }
    }

    private void DeleteProduct(int product_code)
    {
        // Delete product and refresh the data
        products.Delet1Product(product_code);
        ListBox1_SelectedIndexChanged(null, null);  // Refresh DataGrid after deletion
    }
}
