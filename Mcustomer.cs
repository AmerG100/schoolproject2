using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Mcustomer
/// </summary>
public class Mcustomer
{
    private int id_customers;
    private string name;
    private string last_name;
    private string username1;
    private string gender;
    private string phone;
    private string password1;
    static string dbPath;
    static DBConnection DBConn;
    
    public Mcustomer(string p)    //see Global.asax
    {
        dbPath = p;
        DBConn = new DBConnection(dbPath);
    }
    public Mcustomer( string name, string last_name, string username1, string gender, string phone, string password1)
    {
        int id = customers1.GetMaxcustomerId() + 1;
        this.id_customers = id;
        this.name = name;
        this.last_name = last_name;
        this.username1 = username1;
        this.gender = gender;
        this.phone = phone;
        this.password1 = password1;
        
    }
    public Mcustomer(int id,string name, string last_name, string username1, string gender, string phone, string password1)
    {
        this.id_customers = id;
        this.name = name;
        this.last_name = last_name;
        this.username1 = username1;
        this.gender = gender;
        this.phone = phone;
        this.password1 = password1;
        
    }
    public int GetIdcustomer()
    {
        return this.id_customers;
    }
    public string GetName()
    {
        return this.name;
    }
    public string GetLastName()
    {
        return this.last_name;
    }
    public string GetUserName()
    {
        return this.username1;
    }
    public string GetGender()
    {
        return this.gender;
    }
    public string GetPhone()
    {
        return this.phone;
    }
    public string GetPassword()
    {
        return this.password1;
    }
    public override string ToString()
    {
        return username1 + "<br/>" + name + " " + last_name + "<br/> " + phone + "," + gender ;
    }


}