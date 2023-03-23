using System;

public class Address
{
    private string _streetAddress;

    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state,  string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string StreetAddress
    {
        get { return _streetAddress; }
        set { _streetAddress = value; }
    }

    public string City
    {
        get {return _city; }
        set { _city = value; }
    }
    
    public string State
    {
        get {return _state; }
        set {_state = value; }
    }

    public string Country
    {
        get {return _country; }
        set {_country = value; }
    }

   
    
    public void DisplayAddress()
    {
        System.Console.WriteLine($"St. Address: {StreetAddress}");
        System.Console.WriteLine($"City: {City}");
        System.Console.WriteLine($"State/Provinence: {State}");
        System.Console.WriteLine($"Country: {Country}");
    }

    public bool CheckLocation()
    {
        return (Country == "USA");
    }
}