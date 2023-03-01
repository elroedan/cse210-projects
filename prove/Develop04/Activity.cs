

public class Activity {

    private string _activityName;
    private string _description;
    private int _duration;
    private DateTime _startTime = DateTime.Now;
    private DateTime _futureTime ; 

    public Activity(string name, string description) {

        _activityName = name;
        _description = description;

    }

    public int GetTime() {

        System.Console.WriteLine("How long, in seconds, would you like for your session? ");
        string time = Console.ReadLine();
        int duration = int.Parse(time);

        _duration = duration;

        return _duration;

    }
    public void GetReady()
    {
        System.Console.WriteLine("Get ready ...");
        System.Console.WriteLine();
    }

    public void SetTime(int duration) {
        

        _duration = duration;
    }

    public void StartingMessage() {

        System.Console.WriteLine($"Welcome to the {_activityName} Activity");
        System.Console.WriteLine();
        System.Console.WriteLine($"{_description}");
       
    }

    public void EndingMessage () {

        System.Console.WriteLine();
        System.Console.WriteLine("Well Done!");
        System.Console.WriteLine();
        System.Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName} Activity.");
    }

    public void Pause() {

        int pauseTime = 500;
        double _seconds = pauseTime*8;
        while(_seconds > 0)
        {
        Console.Write("|");

        Thread.Sleep(pauseTime);
        _seconds -= pauseTime;

        Console.Write("\b\b"); // Erase the + character
        Console.Write("/"); // Replace it with the - character
        Thread.Sleep(pauseTime);
        
        Console.Write("\b\b");
        Console.Write("-");

        Thread.Sleep(pauseTime);
        Console.Write("\b\b");
        Console.Write("\\"); // Erase the + character
        Thread.Sleep(pauseTime);
        Console.Write("\b\b");
        // Console.Write("|"); // Erase the + character
        Console.Write("\b\b");
        _seconds -=pauseTime;
       
        }
        System.Console.Write("");
        System.Console.Write("\b\b");
    }

    public void Countdown()
    {
        int number = 5;
        while (number != 0)
        {
            System.Console.Write("\b\b");
            System.Console.Write(number);
            Thread.Sleep(1000);
            System.Console.Write("\b\b");
            number -=1;

        }
        System.Console.Write("");
        System.Console.Write("\b\b");
    }

    public DateTime GetCurrentTime()
    {
        return _startTime;
    }


    public void SetFutureTime(int duration) {

        _futureTime = _startTime.AddSeconds(_duration+10);
    
    }
    public DateTime GetFutureTime() 
    {
        return _futureTime;
    }

}