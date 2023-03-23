using System;

public class Customer
{
    private string _name;
    Address address = new Address ("N/A", "N/A", "N/A", "N/A");

    public Customer(string name)
    {
        _name = name;
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
    public string GetCustomerAddress()
    {
        System.Console.WriteLine("Please Enter the following information for shipping:  ");
        System.Console.WriteLine("St.address: ");
        string street = Console.ReadLine();
        address.StreetAddress = street;

        System.Console.WriteLine("City: ");
        string city = Console.ReadLine();
        address.City = city;

        System.Console.WriteLine("State: ");
        string state = Console.ReadLine();
        address.State = state;

        System.Console.WriteLine("Country: ");
        string country = Console.ReadLine();
        address.Country = country;

        
        return $"{CustomerName}- {address.DisplayAddress}";

    }

    
    
}