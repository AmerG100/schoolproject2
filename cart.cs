using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Web.SessionState;

public class Cart : System.Web.UI.Page
{
    DataTable objDT;
    string sID;


    public Cart(string sid)
    {
        objDT = new DataTable("CartDT");
        objDT.Columns.Add("ID");//Integer    //, GetType()
                                //       objDT.Columns["ID"].AutoIncrement = true;
                                //       objDT.Columns["ID"].AutoIncrementSeed = 1;

        objDT.Columns.Add("Product");//string,GetType()
        objDT.Columns.Add("Quantity");//intInteger

        objDT.Columns.Add("Cost");//decimal
        objDT.Columns.Add("RowTotal");//decimal
        //---
        this.sID = sid;
        Page.Session["Cart"] = this;
    }
    public DataTable GetDT()
    {
        return this.objDT;
    }
    public void EmptyTheDTofCart()
    {
        this.DeleteAllRows();
    }
    public string GetSID()
    {
        return this.sID;
    }
    public void makeCart()
    {

    }

    public void AddToCart(string product_code, string Product, string qty, string cost)
    {
        objDT = ((Cart)Session["Cart"]).objDT;

        DataRow objDR;
        bool blnMatch = false;

        foreach (DataRow DR in objDT.Rows)
        {
            if ((string)DR["ID"] == (string)product_code && blnMatch == false) //productX2
            {
                int temp = int.Parse(DR["Quantity"].ToString()) + int.Parse(qty);
                DR["RowTotal"] = decimal.Parse(DR["Cost"].ToString()) * temp;

                DR["Quantity"] = temp.ToString();
                blnMatch = true;

            }
        }

        if (!blnMatch)
        {
            objDR = (DataRow)objDT.NewRow();
            objDR["ID"] = product_code;
            objDR["Product"] = Product;
            objDR["Quantity"] = qty;

            objDR["Cost"] = cost;
            objDR["RowTotal"] = decimal.Parse(cost) * int.Parse(qty);

            objDT.Rows.Add(objDR);
        }
        Session["Cart"] = this;// objDT;


    }

    public Decimal GetItemTotal()
    {
        int intCounter;
        decimal decRunningTotal = 0;
        objDT = ((Cart)Session["Cart"]).objDT;
        if (objDT.Rows.Count > 0)
        {
            //       objDT = (DataTable)Session["Cart"];
            DataRow objDR;

            for (intCounter = 0; intCounter <= objDT.Rows.Count - 1; intCounter++)
            {
                objDR = objDT.Rows[intCounter];
                decRunningTotal += (decimal.Parse(objDR["Cost"].ToString()) * int.Parse(objDR["Quantity"].ToString()));
            }

            return decRunningTotal;
        }
        return 0;
    }
    public void DeleteByIdProd(string idProd)//ind
    {
        
            int i = 0;
            objDT = ((Cart)Session["Cart"]).objDT;
            //objDT.Rows[ind].Delete();
            while (objDT.Rows[i]["ID"].ToString() != idProd)
                i++;
            objDT.Rows[i].Delete();
            Session["Cart"] = this;// objDT;
        
        
    }
    public void UpdateByIdProd(string idProd, string sign)
    {
        int qty = -1;
        int i = 0;
        objDT = ((Cart)Session["Cart"]).objDT;

        while (objDT.Rows[i]["ID"].ToString() != idProd)
            i++;
        if (sign == "+")
            objDT.Rows[i]["quantity"] = int.Parse((objDT.Rows[i]["quantity"]).ToString()) + 1;//= qty
        else
        {
            qty = int.Parse((objDT.Rows[i]["quantity"]).ToString()) - 1;
            objDT.Rows[i]["quantity"] = qty; //= 
            if (qty == 0)
                objDT.Rows[i].Delete();

        }
        if (qty != 0)
            objDT.Rows[i]["RowTotal"] = decimal.Parse((objDT.Rows[i]["cost"]).ToString()) * int.Parse((objDT.Rows[i]["quantity"]).ToString());
        //calculate new RowTotal

        Session["Cart"] = this;// objDT;
    }
    //

    public void Delete(int ind)
    {
        objDT = ((Cart)Session["Cart"]).objDT;
        objDT.Rows[ind].Delete();
        Session["Cart"] = this;// objDT;
    }

    public void Update(int ind, string qty)
    {
        objDT = ((Cart)Session["Cart"]).objDT;
        objDT.Rows[ind]["quantity"] = qty;
        Session["Cart"] = this;// objDT;
    }

    public void DeleteAllRows()
    {
        objDT = ((Cart)Session["Cart"]).objDT;
        //for (int i = 0; i < objDT.Rows.Count; i++)
        //{
        //    Delete(0);
        //}
       
            for (int i = objDT.Rows.Count - 1; i >= 0; i--)
            {
                Delete(i);
            }
        
        

        Session["Cart"] = this;// objDT;
    }
}
