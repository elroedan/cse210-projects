using System;

public class ReceptionEvent : Event
{
    // May need a list of people who have registered 
    private string _email;
    private List<string> registration = new List<string>()
    {
        "callie.wiza64@gmail.com",           
        "eliane_ondricka@gmail.com",
        "connie.mcglynn@yahoo.com",
        "hayden17@gmail.com",
        "tito.herman@gmail.com",
        "alexis.emmerich21@hotmail.com",
        "branson21@yahoo.com",
        "jarrett_hartmann@hotmail.com",
        "alford.kshlerin63@hotmail.com",
        "benjamin_abernathy@yahoo.com",
        "shemar.steuber75@hotmail.com",
        "sophia_harvey31@gmail.com",
        "lila_cummerata99@hotmail.com",
        "abdiel.rogahn11@hotmail.com",
        "dasia.denesik83@hotmail.com",
    };

    public ReceptionEvent() : base()
    {

    }

    public string Email
    {
        get {return _email; }
        set {_email = value; }
    }

    /*
    This code is in case I would like the user to input their email so it can add it to the list
    // public void AddEmailRecord(string email)
    // {   
    //     registration.Add(email);
    // }

    */
    public override void DisplayFullDetail()
    {
        DisplayStandardDetails();
        System.Console.WriteLine($"Reception Event");
        int number = 1;
        foreach(string email in registration)
        {
            System.Console.WriteLine($"{number}. {email}");
            number += 1;
        }
        number = 1;

    }

    public override void GetEventData()
    {
        base.GetEventData();

    }
     public override void DisplayShortDescription()
    {
        System.Console.WriteLine($"Reception Event: \nTitle: {Title}\nDate: {Date}");
    }

     
}