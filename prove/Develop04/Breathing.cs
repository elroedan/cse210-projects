public class Breathing : Activity{
    public Breathing() : base("Breathing", 
    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.") {

    }
    public void BreathIn()
    {
        System.Console.WriteLine("Breath in ...");
    }
    public void BreathOut()
    {
        System.Console.WriteLine("Now Breath out ...");
        System.Console.WriteLine();
    }

    public void StartBreathingActivity()
    {
        StartingMessage();
        int duration = GetTime();
        
        Console.Clear();
        GetReady();
        
        Pause();
        Console.Clear();

        DateTime startTime = GetCurrentTime();
        SetFutureTime(duration);
        DateTime futureTime = GetFutureTime();
        DateTime currentTime = DateTime.Now;

        int delay = 500;
        bool visible = true;
        while ( currentTime < futureTime)
        {   
            currentTime = DateTime.Now;    

            Console.Clear();

            if (visible)
            {
                BreathIn();
                Countdown(); 
                visible = false;
            }
            else
            {
                BreathOut();
                Countdown();
                visible = true;
            }

            Thread.Sleep(delay);
        }
            

        

        EndingMessage();
        Pause();
    }

    
}