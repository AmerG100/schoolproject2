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
/// Summary description for ezer
/// </summary>
public class ezerTables : Basis
{

    //static string dbPath;
    //static DBConnection DBConn;
    public ezerTables(string p) : base(p)
    {

    }


    public static DataSet GetAllTableItems(string tbEzer, string nose)
    {

        return DBConn.RunDataSetSQL("select * from  " + tbEzer + " order by " + nose );
    }
    public static string ConvertIdToName(object tbName, object nose, object num)
    {


        DataSet dsTm = DBConn.RunDataSetSQL("select * from " + tbName + " where " + nose + "=" + num);
        return (string)dsTm.Tables[0].Rows[0][1];//0-id,1-name
    }

    //---
    public static string ChgBack(object x)
    {
        return x.ToString().Replace("~", "'");
    }
    public static string ChgTheGersh(object x)
    {
        return x.ToString().Replace("'", "~");
    }

    public static string PictureCode(FileUpload fu)
    {

        string strBaseDir, strFileName = "";

        //Save the file if it has a filename and exists...
        if (!(fu.PostedFile == null) && fu.PostedFile.FileName.Trim().Length > 0 &&
               fu.PostedFile.ContentLength > 0)
        {
            string fName = fu.PostedFile.FileName.Trim();

            strBaseDir = HttpContext.Current.Server.MapPath("~/Images/");
            Random rn = new Random();
            strFileName = rn.Next(10000) +
               fName;//Path.GetFileName(fu.PostedFile.FileName);
            string allPath = strBaseDir + strFileName;
            fu.PostedFile.SaveAs(allPath);
        }
        return strFileName;
    }
}
