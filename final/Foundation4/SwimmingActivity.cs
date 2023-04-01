using System;

public class SwimmingActivity : Activity
{
    private int _laps;

    public int Laps
    {
        get {return _laps; }
        set {_laps = value; }
    }

    public override string ExerciseSummary()
    {
        double distance = Laps * 50 / 100;
        double speed = (distance / Length) * 60;
        double pace = Length / distance;

        return $"{base.ExerciseSummary()} - Distance {distance} km, Speed: {speed} kph, Pace: {pace} min per kilometer";
    }

    public override void GetActivityData()
    {
        base.GetActivityData();
        System.Console.Write("How many Laps did you finish? ");
        Laps = int .Parse(Console.ReadLine());
    }

}