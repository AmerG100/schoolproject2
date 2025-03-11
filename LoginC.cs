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
/// Summary description for LoginC
/// </summary>
public class LoginC :Basis
{
    static string dbPath;
    
    public LoginC(string p) :base(dbPath)   //see Global.asax
    {
        dbPath = p;
        
    }


    public static DataSet GetAllUsersByUserName(string id)
    {
        return DBConn.RunDataSetSQL("select * from customers where username1='" + id + "'");
    }
    public static int NumOfOk(string usr, string pswrd)
    {
        string sql = "select * from admin where user='" + usr + "' and pass='" + pswrd + "'";
        return DBConn.RunDataSetSQL(sql).Tables[0].Rows.Count;
    }
}