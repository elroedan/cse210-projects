using System;

public class Address
{
    List<string> addresses = new List<string>()
    {
        "786 Lonely Oak Drive|Fuquay Varina|North Carolina|United States", "1525 Lonely Oak Drive|Mobile|Alabama|United States",
        "109 Coburn Hollow Road|Glasford|Illinois|United States", "1101 Freshour Circle|Mariposa|California|United States",
        "603 Elk Street|San Diego|California|United States", "2026 Oak Street|Skaneateles|New York|United States"

    };
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

    public Address()
    {

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
        GenerateRandomAddress();
        System.Console.WriteLine($"     St. Address: {StreetAddress}");
        System.Console.WriteLine($"     City: {City}");
        System.Console.WriteLine($"     State/Provinence: {State}");
        System.Console.WriteLine($"     Country: {Country}");
    }

    public void GenerateRandomAddress()
    {
        Random random = new Random();
        int length = addresses.Count;
        int index = random.Next(length);
        string address = addresses[index];
        char[] delimiterChars = {'|'};
        string[] words = address.Split(delimiterChars);

        StreetAddress = words[0];
        City = words[1];
        State = words[2];
        Country = words[3];
    }

    
   




}