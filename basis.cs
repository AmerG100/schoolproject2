using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Basis
/// </summary>
public class Basis
{

    protected static DBConnection DBConn;
    //gets the path from Application_Start of global.asax
    //and builds the base of all methods
    public Basis(string dbPath)
    {
        DBConn = new DBConnection(dbPath);
    }
}