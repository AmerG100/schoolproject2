using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
/// <summary>
/// Summary description for usingClasses
/// </summary>
public class usingClasses:Basis
{
    public usingClasses():base("")
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static DataSet xyz()
    {
        return DBConn.RunDataSetSQL("select * from customers order by name");
    }
    public static DataSet GetAllCustomers()
    {
        return DBConn.RunDataSetSQL("select * from customers");
    }

    public static DataSet GetAllCustomersSORTED()
    {
    return DBConn.RunDataSetSQL("select * from customers order by name");
                                                    //order by name desc לסדר יורד
    }

    public static DataSet PurchasesBy1Customer (string idC)
    {
       return DBConn.RunDataSetSQL("select * from deals where customers=" + idC);
         
    }
    public static DataSet GetAlltypes()
    {
        return DBConn.RunDataSetSQL("select * from type order by type");

    }
    public static DataSet ProductBy1type(string idC)
    {
        return DBConn.RunDataSetSQL("select * from products where product_type=" + idC+"AND exist=true");

    }
    public static DataSet GetAllemployees()
    {
        return DBConn.RunDataSetSQL("select * from employees order by name");

    }
    public static DataSet EmployeesBy1name(string idC)
    {
        return DBConn.RunDataSetSQL("select * from employees where employeesID=" + idC);

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
    public static DataSet GetPicturesBy1Product(string id)
    {
        return DBConn.RunDataSetSQL("select picture from products where product_code=" + id );
    }
    public static DataSet GetAllpictures()
    {
        return DBConn.RunDataSetSQL("select * from products order by picture");

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
    public static string ConvertIdToEmp(string idc)
    {
        DataSet ds = DBConn.RunDataSetSQL("select * from employees where employeesID=" + idc);
        return ds.Tables[0].Rows[0][1] + "";

    }
    private string GetCustomerIDByName(string customerName)
    {
        DataSet ds = DBConn.RunDataSetSQL("select * from customers where name=" + customerName);
        return ds.Tables[0].Rows[0][0] + "";
    }





}