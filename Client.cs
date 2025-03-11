using System;
using System.Collections.Generic;
using System.Text;


public class Client
{
    private string username;
    private string password;
    private string firstName;
    private string lastName;
    private string address;
    private string city;

    private string email;
    private string phone;




    public Client(string username, string password, string firstName, string lastName, string address, string city,
                    string email, string phone)
    {
        this.username = username;
        this.password = password;
        this.firstName = firstName;
        this.lastName = lastName;
        this.address = address;
        this.city = city;

        this.email = email;
        this.phone = phone;

    }
    public string GetUserName()
    {
        return this.username;
    }
    public string GetPassword()
    {
        return this.password;
    }

    public string GetFirstName()
    {
        return this.firstName;
    }

    public string GetLastName() ////
    {
        return this.lastName;
    }
    public string GetAddress() ////
    {
        return this.address;
    }
    public string GetCity() ////
    {
        return this.city;
    }
    //...

    public string GetEmail() ////
    {
        return this.email;
    }
    public string GetPhone() ////
    {
        return this.phone;
    }



    public override string ToString()
    {
        return username + "<br/>" + firstName + " " + lastName + "<br/> " + address + "," + city +
                       "<br/>" + email + "," + phone;
    }
}

