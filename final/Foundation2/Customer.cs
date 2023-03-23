using System;

public class Customer
{
    private string _name;
    Address address = new Address ();

    public Customer(string name)
    {
        _name = name;
    }

    public Customer()
    {

    }
    public string CustomerName
    {
        get {return _name; }
        set {_name = value;}
    }


    public bool GetCustomerLocation()
    {   

        return address.CheckLocation();
    }

    public void DisplayCustomerAddress()
    {
        address.DisplayAddress();
    }
    public void GetCustomerAddress()
    {
        System.Console.WriteLine("Please Enter the following information for shipping:  ");
        System.Console.Write("St.address: ");
        string street = Console.ReadLine();
        address.StreetAddress = street;

        System.Console.Write("City: ");
        string city = Console.ReadLine();
        address.City = city;

        System.Console.Write("State: ");
        string state = Console.ReadLine();
        address.State = state;

        System.Console.Write("Country: ");
        string country = Console.ReadLine();
        address.Country = country;

        
        // return $"{CustomerName}- {address.DisplayAddress}";

    }

    
    
}