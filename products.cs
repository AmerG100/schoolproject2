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
/// Summary description for products
/// </summary>
public class products:Basis
{
   
    static string dbPath;
    
    public products(string p):base(dbPath)    //see Global.asax
    {
        dbPath = p;
       
    }

    

    public static Mproduct Get1product(string id)
    {

        DataSet ds = DBConn.RunDataSetSQL("select * from products where product_code= " + id);
        //int prId = int.Parse(ds.Tables[0].Rows[0][0].ToString());
        int prid = int.Parse(id);
        string prName = ds.Tables[0].Rows[0][2].ToString();
        int prtype = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        int prstock = int.Parse(ds.Tables[0].Rows[0][3].ToString());

        double prPrice = double.Parse(ds.Tables[0].Rows[0][4].ToString());
        string prPic = ds.Tables[0].Rows[0][5].ToString();
        bool exist= bool.Parse(ds.Tables[0].Rows[0][6].ToString());

        Mproduct prObj = new Mproduct(prid,prtype,prName,prstock,prPrice,prPic,exist);
        return prObj;

    }
    public static string GettypeNameById(object catNum)
    {

        string cat = catNum.ToString();
        DataSet dstyp = DBConn.RunDataSetSQL("select * from type where id_type =" + cat);
        return (string)dstyp.Tables[0].Rows[0]["type"];
    }
    public static string GetItemDetailsById(object product_code)
    {


        string id = product_code.ToString();
        DataSet dsItem = DBConn.RunDataSetSQL("select * from products where product_code= " + id);
        string st = (string)dsItem.Tables[0].Rows[0]["product_name"];


        return st;
       
        
            
        

    }
    public static string ConvertIdToProduct(string idc)
    {
        DataSet ds = DBConn.RunDataSetSQL("select * from products where product_code=" + idc);
        return ds.Tables[0].Rows[0][2] + "";

    }
    public static string ConvertIdToProduct1(string idc)
    {
        DataSet ds = DBConn.RunDataSetSQL("select * from products where product_code=" + idc);
        return ds.Tables[0].Rows[0][4] + "";

    }
    public static void Add1Product(Mproduct pl)
    {
        //int id = pl.GetProductCode();
        int type = pl.GetProductType();
        string name = pl.GetProductName() ;
        int stock = pl.GetStock();
        double price = pl.GetPrice();
        string pic = pl.GetPicture().ToString();
        if (pic == "")
            pic = "no_image.jpg";


        
        string strSql = "insert into products (product_type,product_name,stock,price,picture) ";
        strSql += "values(";
        strSql += "" + type + ",";
        strSql += "'" + name + "',";
        strSql += "" + stock + ",";
        strSql += "" + price + ",";
        strSql += "'" + pic + "'";
       


        strSql += ")";
        DBConn.RunNonQuerySQL(strSql);
    }
    public static int GetMaxproductId()
    {
        DataSet ds = DBConn.RunDataSetSQL("select max(product_code) from products");
        return int.Parse(ds.Tables[0].Rows[0][0].ToString());

    }
    public static void Update1Product(Mproduct tm)
    {
        int id = tm.GetProductCode();

        string tmName = tm.GetProductName();
        int type = tm.GetProductType();
        int stock = tm.GetStock();
        double price = tm.GetPrice();
        string tmPic = tm.GetPicture();
        bool exist = tm.GetProductexist();

        string strSql = "update products set product_type='{0}',product_name='{1}',stock='{2}',price={3},exist={4}  where product_code={5}";
        string strSqlFrmt = String.Format(strSql, type, tmName, stock, price,exist, id);
        DBConn.RunNonQuerySQL(strSqlFrmt);//updating all but the picture

        if (tmPic != "")
            DBConn.RunNonQuerySQL("update products set picture='" + tmPic + "'  where product_code =" + id);
        //update the pic    , if needed
    }
    public static void Delet1Product(int id)
    {
        

        string strSql = "update products set exist=false  where product_code={0}";
        string strSqlFrmt = String.Format(strSql,  id);
        DBConn.RunNonQuerySQL(strSqlFrmt);

        
    }
}