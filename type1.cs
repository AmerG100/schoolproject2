using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for type
/// </summary>
public class type1 : Basis
{
    public type1(string p) : base(p)
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static DataSet GetAlltypes()
    {
        return DBConn.RunDataSetSQL("select * from type order by type");
        
    }

    public static DataSet GetAlltypeByLetter(string ot)
    {
        string st = "select * from type where name like '" + ot + "%' order by type";
        return DBConn.RunDataSetSQL(st);
    }
    public static DataSet ProductBy1type(string idC)
    {
        return DBConn.RunDataSetSQL("select * from products where product_type=" + idC);

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
        return DBConn.RunDataSetSQL("select picture from products where product_code=" + id);
    }
    public static string GettypeNameById(object catNum)
    {

        string cat = catNum.ToString();
        DataSet dsCat = DBConn.RunDataSetSQL("select * from type where id_type=" + cat);
        return (string)dsCat.Tables[0].Rows[0]["type"];
    }


}