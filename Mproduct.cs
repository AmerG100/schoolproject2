using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Mproduct
/// </summary>
public class Mproduct
{
    private int product_code;
    private int product_type;
    private string product_name;
    private int stock;
    private double price;
    private string picture;
    private bool exist;

    public Mproduct() { }
    public Mproduct(int product_code, int product_type, string product_name, int stock, double price, string picture,bool ext)
    {
        this.product_code = product_code;
        this.product_type = product_type;
        this.product_name = product_name;
        this.stock = stock;
        this.price = price;
        this.picture = picture;
        this.exist = ext;
    }


    public int GetProductCode()
    {
        return this.product_code;
    }
    public bool GetProductexist()
    {
        return this.exist;
    }
    public int GetProductType()
    {
        return this.product_type;
    }

    public string GetProductName()
    {
        return this.product_name;
    }
    public int GetStock()
    {
        return this.stock;
    }
    public double GetPrice()
    {
        return this.price;
    }
    public string GetPicture()
    {
        return this.picture;
    }
    public void  SetProductCode(int pr)
    {
        this.product_code = pr;
    }
    public void SetProductType(int typ)
    {
        this.product_type = typ;
    }

    public void SetProductName(string name)
    {
        this.product_name = name;
    }
    public void SetStock(int st)
    {
        this.stock = st;
    }
    public void SetPrice(double pr)
    {
        this.price = pr;
    }
    public void SetPicture(string pic)
    {
        this.picture = pic;
    }

}