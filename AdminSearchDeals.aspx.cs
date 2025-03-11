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
using System.IO;
using System.Data.OleDb;




public partial class AdminSearchDeals : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        lblError.Visible = false;
        if (Session["mutar"] == "")
        {
            Response.Redirect("../default.aspx");
        }
        else
        {
            if (Request["orderId"] != null)
            {

                DataSet ds = Deals.GetAllOrdersDetailsByOrderId(Request["orderId"]);
                DataGrid2.DataSource = ds;
                DataGrid2.DataBind();
                DataGrid2.Visible = true;
                DataGrid1.Visible = true;

            }
            else
            { DataGrid2.Visible = false; }


        }


       
    }

        protected void calFromDate_SelectionChanged(object sender, EventArgs e)
        {
            txtFromDate.Text = calFromDate.SelectedDate.ToString("yyyy-MM-dd");
        }

        protected void calToDate_SelectionChanged(object sender, EventArgs e)
        {
            txtToDate.Text = calToDate.SelectedDate.ToString("yyyy-MM-dd");
        }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string connString = "Provider=Microsoft.jet.OLEDB.4.0;Data Source=|DataDirectory|\\amernewproject11.mdb;";

        using (OleDbConnection conn = new OleDbConnection(connString))
        {
            DataGrid2.Visible = false;

            string query = "SELECT id_deal, customers, deal_date FROM deals WHERE 1=1";
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                if (!string.IsNullOrEmpty(txtDealID.Text))
                {
                    query += " AND id_deal = ?";
                    cmd.Parameters.AddWithValue("?", txtDealID.Text);
                }

                if (!string.IsNullOrEmpty(txtCustomerName.Text))
                {
                    string id_customers = GetCustomerIDByName(txtCustomerName.Text, conn);
                    if (!string.IsNullOrEmpty(id_customers))
                    {
                        query += " AND customers = ?";
                        cmd.Parameters.AddWithValue("?", int.Parse(id_customers));
                    }
                    else
                    {
                        lblError.Visible = true;
                        lblError.Text = "Customer not found.";
                        DataGrid1.Visible = false;
                        return;
                    }
                }

                if (!string.IsNullOrEmpty(txtFromDate.Text) && !string.IsNullOrEmpty(txtToDate.Text))
                {
                    query += " AND deal_date BETWEEN ? AND ?";
                    cmd.Parameters.AddWithValue("?", DateTime.Parse(txtFromDate.Text));
                    cmd.Parameters.AddWithValue("?", DateTime.Parse(txtToDate.Text));
                }

                cmd.CommandText = query;

                OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                DataGrid1.DataSource = dt;
                DataGrid1.DataBind();
            }
        }
    }
    protected string ConvertIdtoTotal(object orderId)
    {
        return Deals.GetTotalOrder(orderId + "").ToString();
    }
    private string GetCustomerIDByName(string customerName, OleDbConnection conn)
    {
        string query = "SELECT id_customers FROM customers WHERE name = '"+ customerName+"'";

        using (OleDbCommand cmd = new OleDbCommand(query, conn))
        {
            conn.Open();
            cmd.Parameters.AddWithValue("@CustomerName", customerName);

            object result = cmd.ExecuteScalar();
            return result != null ? result.ToString() : string.Empty;
        }


    }




   
}

