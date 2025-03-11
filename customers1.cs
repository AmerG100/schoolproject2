using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for customer1
/// </summary>
public class customers1 : Basis
{
    public customers1(string p) : base(p)
    {

    }

    public static DataSet GetAllCustomers()
    {
        return DBConn.RunDataSetSQL("select * from customers order by name");
    }

    public static DataSet GetAllCustomersByLetter(string ot)
    {
        string st = "select * from customers where name like '" + ot + "%' order by name";
        return DBConn.RunDataSetSQL(st);
    }
    public static DataSet GetAllCustomersSORTED()
    {
        return DBConn.RunDataSetSQL("select * from customers order by name");
        //order by name desc לסדר יורד
    }
    public static DataSet PurchasesBy1Customer(string idC)
    {
        return DBConn.RunDataSetSQL("select * from deals where customers=" + idC);

    }

    public static void Add1Client(Mcustomer cl)
    {
        ////string id = pl.GetPlayerId().ToString();
        //Page pg = new Page();
        //string p = pg.Server.MapPath("~/App_Data/teamplayer.mdb");
        //DBConnection DBConn = new DBConnection(p);
        int clID = cl.GetIdcustomer();
        
        string clUser = cl.GetUserName();
        string clPass = cl.GetPassword();
        string clFN = cl.GetName();
        string clLN = cl.GetLastName();
        string clGn = cl.GetGender();

        string clPhone = cl.GetPhone();

        string strSql = "insert into customers (id_customers,name,last_name,username1,gender,phone,password1) ";
        strSql += "values(";
        strSql +=  clID + ",";
        strSql += "'" + clFN + "',";
        strSql += "'" + clLN + "',";
        strSql += "'" + clUser + "',";
        strSql += "'" + clGn + "',";
        strSql += "'" + clPhone + "',";
        strSql += "'" + clPass + "'";


        strSql += ")";
        DBConn.RunNonQuerySQL(strSql);


    }
    public static Mcustomer Get1customer(string id)
    {

        DataSet ds = DBConn.RunDataSetSQL("select * from customers where username1='" + id + "'");
        int id1 = int.Parse((ds.Tables[0].Rows[0][0].ToString()));
        string username = (ds.Tables[0].Rows[0][3].ToString());
        string password = ds.Tables[0].Rows[0][6].ToString();
        string firstName = ds.Tables[0].Rows[0][1].ToString();
        string lastName = (ds.Tables[0].Rows[0][2].ToString());
        string gender = ds.Tables[0].Rows[0][4].ToString();
        string phone = ds.Tables[0].Rows[0][5].ToString();

        Mcustomer clientObj = new Mcustomer(id1,firstName,lastName,username,gender,phone,password);
        return clientObj;

    }
    public static int GetcustomerNumbyusername(string idc)
    {
        DataSet ds = DBConn.RunDataSetSQL("select * from customers where username1=" + idc);
        return int.Parse(ds.Tables[0].Rows[0][0].ToString());

    }
    public static int GetMaxcustomerId()
    {
        DataSet ds = DBConn.RunDataSetSQL("select max(id_customers) from customers");
        return int.Parse(ds.Tables[0].Rows[0][0].ToString());
        
    }
    public static string ConvertIdToCustomer(string idc)
    {
        DataSet ds = DBConn.RunDataSetSQL("select * from customers where id_customers=" + idc);
        return ds.Tables[0].Rows[0][1] + "";

    }
    public static string ConvertIdToCustomerLast(string idc)
    {
        DataSet ds = DBConn.RunDataSetSQL("select * from deals where id_deal=" + idc);
        return ds.Tables[0].Rows[0][2] + "";

    }
}
    