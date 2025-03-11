using System;
using System.Collections.Generic;
using System.Text;


public class Deal
{
    private int id_deal;
    private int customers;
    private DateTime deal_date;
    private int deal_employee;
    


    public Deal(int id,int customers, DateTime deal_date, int deal_employee)
    {
        this.id_deal = id;
        this.customers = customers;
        this.deal_date = deal_date;
        this.deal_employee = deal_employee;
        


    }
    public int GetOrderId()
    {
        return this.id_deal;
    }
    public int GetCustomer()
    {
        return this.customers;
    }

    public DateTime Getdeal_date()
    {
        return this.deal_date;
    }

    
    public int GetDealemployee() ////
    {
        return this.deal_employee;
    }
    public override string ToString()
    {
        return "order DONE. ID-{" + id_deal +"}" + ",date: " + deal_date.ToShortDateString();
    }
}

