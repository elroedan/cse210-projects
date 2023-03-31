using System;

public class OutdoorEvent : Event
{   
    private int _temprature;

    public int Temprature
    {
        get {return _temprature; }
        set {_temprature = value; }
    }

    public void GetRandomTemprature()
    {
        Random random = new Random();
        int maxTemprature = 115;
        int randomTemprature = random.Next(maxTemprature);

        Temprature = randomTemprature;

        
    }

    public string GetForecast()
    {
        GetRandomTemprature();
        switch(Temprature)
        {
            case < 30:
                return $"Recomended that you bring a jacket. The temprature is {Temprature}°F";

            case < 60:
                return $"It is partially sunny. The temprature is {Temprature}°F";

            case < 90:
                return $"It is sunny. The temprature is {Temprature}°F";

            case >= 90:
                return $"It is a hot day. The temprature is {Temprature}°F";
                
        }
    }

    public override void DisplayFullDetail()
    {
        DisplayStandardDetails();
        System.Console.WriteLine($"Outdoor Event \n{GetForecast()} ");
    }

     public override void DisplayShortDescription()
    {
        System.Console.WriteLine($"Outdoor Event: \nTitle: {Title}\nDate: {Date}");
    }

    public override void GetEventData()
    {
        base.GetEventData();
    }
}