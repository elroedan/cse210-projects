using System;

public class RunningActivity : Activity
{

    private double _distance;
   
   
    public RunningActivity()
    {
        
    }
    public double Distance
    {
        get {return _distance; }
        set {_distance = value; }
    }
    public override void GetActivityData()
    {
        base.GetActivityData();
        System.Console.Write("What is the total distance? ");
        Distance = double.Parse(Console.ReadLine());
    }
    public override string GetSummary()
    {
        double speed = Distance / Length;
        double pace =  Length / Distance;

        return $"Running Activity\n{base.GetSummary()} -\n Distance {Distance} Km Speed {speed} Km/hr\n Pace: {pace} min per Kilometer";
    }
}