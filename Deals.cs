using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Summary description for Teams
/// </summary>
public class Deals:Basis
{
    static string dbPath;
    
    public Deals(string p):base(dbPath)    //see Global.asax
    {
        dbPath = p;
       
    }

    public static DataSet GetAllOrdersByClient(int id)
    {
        return DBConn.RunDataSetSQL("select * from deals where customers= " + id + " order by id_deal desc");
    }
    public static DataSet GetAllOrdersDetailsByOrderId(string id)
    {
        return DBConn.RunDataSetSQL("select * from deal_details where id_deal=" + id);
    }


    public static DataSet GetAllOrders()
    {
        return DBConn.RunDataSetSQL("select * from deals order by id_deal");
    }

    public static int GetMaxOrderId()
    {
        DataSet ds = DBConn.RunDataSetSQL("select max(id_deal) from deals");
        return int.Parse(ds.Tables[0].Rows[0][0].ToString());
        //int id = Deal.index2;
        //return id ;
    }
    public static string Getemployeebyusr(string usr)
    {
        DataSet ds = DBConn.RunDataSetSQL("select * from deals where username1 = "+usr);
        return ds.Tables[0].Rows[0][4].ToString();
    }

    public static Deal Get1Order(string id)
    {

        DataSet ds = DBConn.RunDataSetSQL("select * from deals where id_deal=" + id);
        
        int customers = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        DateTime deal_date = (DateTime)ds.Tables[0].Rows[0][2];
        

        int deal_employee = int.Parse(ds.Tables[0].Rows[0][4].ToString());
        int id2 = int.Parse(id);

        Deal orderObj = new Deal(id2,customers,deal_date,deal_employee);
        return orderObj;

    }

    public static void Add1Order(Deal ord)
    {
        int id = ord.GetOrderId();
        int ordUser = ord.GetCustomer();
        string ordDt = ord.Getdeal_date().Date.ToShortDateString();
        int employee = ord.GetDealemployee();
        int deal_stat = 1;




        string strSql = "insert into deals (id_deal,customers,deal_date,deal_status,deal_employee) ";
        strSql += "values(";
        strSql += id + ",";
        strSql +=  ordUser + ",";
        strSql += "#" + ordDt + "#,";
        strSql +=  deal_stat + ",";
        strSql +=  employee ;



        strSql += ")";
        DBConn.RunNonQuerySQL(strSql);
        



    }

    public static void AddOrderDetails(int ord, DataTable crt)
    {
        int id_deal, product, num_products;
        double price;
        
        for (int i = 0; i < crt.Rows.Count; i++)
        {
            id_deal = ord;
            product = int.Parse(crt.Rows[i]["ID"].ToString());
            num_products = int.Parse(crt.Rows[i]["Quantity"].ToString());
            price = double.Parse(crt.Rows[i][3].ToString());//cost
          

            string strSql = "insert into deal_details (id_deal,product,actual_price,num_product) ";
            strSql += "values(";
            strSql += id_deal + ",";
            strSql += product + ",";
            strSql += price + ",";
            strSql += num_products;

            strSql += ")";
            DBConn.RunNonQuerySQL(strSql);
        }





    }
    public static int GetorderidbyusrId(int id)
    {
        DataSet ds = DBConn.RunDataSetSQL("select * from deals where customers = " + id);
        return int.Parse(ds.Tables[0].Rows[0][0].ToString());
    }
    public static double GetTotalOrder(string id)
    {
        DataSet ds = DBConn.RunDataSetSQL("select * from deal_details where id_deal=" + id);
        double total = 0;
        







        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
        {
            total += double.Parse(ds.Tables[0].Rows[i][2].ToString()) * double.Parse(ds.Tables[0].Rows[i][3].ToString());
            
        }
            
                
            
            
      
        return total;
        
    }
}