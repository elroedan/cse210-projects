using System;

public abstract class Activity
{
   private DateTime _date = new DateTime();
   private double _length;
   public DateTime Date
   {
    get {return _date; }
    set {_date = value; }
   } 

   public double Length
   {
    get {return _length; }
    set {_length = value; }
   }

    public virtual void GetActivityData()
    {
        System.Console.Write("\n\n\nWhat is the amount of time you did this activity? ");
        Length = double.Parse(Console.ReadLine());
        Date = DateTime.Now;
    }
    public virtual string ExerciseSummary()
    {
        return $"{Date.ToShortDateString()} Exercise ({Length} min)";
    }


}
