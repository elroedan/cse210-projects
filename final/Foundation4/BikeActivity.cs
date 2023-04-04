using System;

public class BikeActivity : Activity
{
    private double _speed;
    public double Speed
    {
        get {return _speed; }
        set {_speed = value; }
    }

    public override void GetActivityData()
    {
        base.GetActivityData();
        System.Console.Write("How was your speed? ");
        Speed = double.Parse(Console.ReadLine());
    }

    public override string GetSummary()
    {
        return $"Bike Activity\n{base.GetSummary()} - Speed {Speed} mph";
    }
}