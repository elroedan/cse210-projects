public class Listing : Activity {

    private string  _prompt;
    private List<string> _prompts = new List<string>(){
"Who are people that you appreciate?", "What are personal strengths of yours?", 
"Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", 
"Who are some of your personal heroes?"
    };

    private List<string> _entries = new List<string>();
    private string _entry;
    public Listing() : base ("Listing", 
    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
       
    } 

    public string GetPrompt() 
    {
        Random randomGenerator = new Random();
        int randomIndex = randomGenerator.Next(_prompts.Count());
        _prompt = _prompts[randomIndex];
        return _prompt;

     
    }
    public void DisplayPrompt()
    {        
        System.Console.WriteLine("List as many responses as you can to the following prompt: ");
        System.Console.WriteLine($"   --- {_prompt} ---");
        System.Console.WriteLine("You may Begin in  ");
    }

    public string GetEntry()
    {
        Console.WriteLine("> ");
        _entry = Console.ReadLine();

        return _entry;
    }

    public void AddToEntry(string entry) 
    {
        _entries.Add(entry);
    }

    public void ReturnEntry()
    {
        System.Console.WriteLine($"You Listed the following entries: ");
        foreach (string entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }


    public void StartListingActivity() 
    {
        StartingMessage();
        int duration = GetTime();
        Console.Clear();    
        GetReady();
        Pause();
        Console.Clear();
        GetPrompt();
        DisplayPrompt();
        Countdown();
        // CountDown Function

        // While countdown start start looping
        DateTime startTime = GetCurrentTime();
        SetFutureTime(duration);
        DateTime futureTime = GetFutureTime();
        DateTime currentTime = DateTime.Now;
        while ( currentTime < futureTime)
        {   
            currentTime = DateTime.Now;
            string write = GetEntry();
            AddToEntry(write);

        }
        // When finished looping pause for a second then 
        Pause();
        Console.Clear();
        ReturnEntry();
        Pause();

        EndingMessage();
        Pause();

    }

}