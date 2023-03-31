using System;

public abstract class Event
{
    private string _title;
    private string _description;
    private DateOnly _date;
    
    private TimeOnly _time;
    

    public string Title
    {
        get {return _title; }
        set {_title = value; }
    }

    public string Description
    {
        get {return _description; }
        set {_description = value; }
    }

    public DateOnly Date
    {
        get {return _date; }
        set {_date = value; }
    }
    public TimeOnly Time
    {
        get {return _time; }
        set {_time = value; }
    }

    Address address = new Address();
    public void DisplayStandardDetails()
    {
        System.Console.WriteLine($"Title: {Title}\nDescription: {Description}");
        System.Console.WriteLine($"Date and Time: {Date} @ {Time}");
        System.Console.WriteLine($"Address:");
        address.DisplayAddress();
    }

    public virtual void GetEventData()
    {
        System.Console.Write("What is the Event title? ");
        Title = Console.ReadLine();
        System.Console.Write("Enter Date: ");
        DateOnly date = DateOnly.Parse(Console.ReadLine());
        Date = date;
        System.Console.WriteLine();
        System.Console.Write("What time is the event? ");
        TimeOnly time = TimeOnly.Parse(Console.ReadLine());
        Time = time;
        System.Console.Write("Write a small description of the event? ");
        Description = Console.ReadLine();


    }
    public abstract void DisplayShortDescription();

    public abstract void DisplayFullDetail();
   


}