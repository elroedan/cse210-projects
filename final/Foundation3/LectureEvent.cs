using System;

public class LectureEvent : Event
{
    private int _capacity;
    private string _speaker;

    public LectureEvent() : base()
    {

    }
    public int Capacity
    {
        get {return _capacity; }
        set {_capacity = value; }
    }

    public string Speaker
    {
        get {return _speaker; }
        set {_speaker = value; }
    }

    public override void GetEventData()
    {
        base.GetEventData();
        System.Console.Write("Who is the guest speaker? ");
        Speaker = Console.ReadLine();
        System.Console.Write("What is the maximum capacity of this event? ");
        Capacity = int.Parse(Console.ReadLine());


    }
    public override void DisplayFullDetail()
    {
        System.Console.WriteLine($"Lecture Event \nSpeaker: {Speaker} \nMaximum Capacity: {Capacity}");
        DisplayStandardDetails();
    }
    public override void DisplayShortDescription()
    {
        System.Console.WriteLine($"Lecture Event: \nTitle: {Title}\nDate: {Date}");
    }

}