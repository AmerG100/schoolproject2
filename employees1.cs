using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for employees1
/// </summary>
public class employees1:Basis
{
    public employees1(string p):base(p)
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public static DataSet GetAllemployees()
    {
        return DBConn.RunDataSetSQL("select * from employees order by name");

    }

    public static DataSet GetAllemployeesByLetter(string ot)
    {
        string st = "select * from employees where name like '" + ot + "%' order by name";
        return DBConn.RunDataSetSQL(st);
    }
    public static DataSet EmployeesBy1name(string idC)
    {
        return DBConn.RunDataSetSQL("select * from employees where employeesID=" + idC);

    }
    public static string ConvertIdToEmp(string idc)
    {
        DataSet ds = DBConn.RunDataSetSQL("select * from employees where employeesID=" + idc);
        return ds.Tables[0].Rows[0][1] + "";

    }
}