
public class Reflecting : Activity
{
    public Reflecting() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.") 
    {
    }
    private string _prompt;
    private string _question;
    private List<string> _prompts = new List<string> (){
    "Think of a time when you stood up for someone else.", 
    "Think of a time when you did something really difficult.", 
    "Think of a time when you helped someone in need.", 
    "Think of a time when you did something truly selfless."} ;

    private List<string> _questions = new List<string>(){ 
      "Why was this experience meaningful to you?", "Have you ever done anything like this before?" ,
      "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?",
      "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?",
      "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"

    };

    public string GetQuestion() 
    {
        Random randomgenerator = new Random();
        int randomIndex = randomgenerator.Next(_questions.Count());
        _question = _questions[randomIndex];

        return _question;
    }
    public void DisplayQuestion(string question)
    {
        _question = question;
        System.Console.WriteLine();
        System.Console.WriteLine(_question);
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
        
        System.Console.WriteLine();
        System.Console.WriteLine("Consider the following prompt:");
        System.Console.WriteLine($"   --- {_prompt} ---");
        System.Console.WriteLine();
        System.Console.WriteLine("When you have something in mind, Press Enter to continue");
        Console.ReadLine();
    }
    public void DisplayQuestionPrep()
    {
        System.Console.WriteLine("Now ponder on each of the following question as they related to this experience to this experience.");
    }

    public void StartReflectingActivity()
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
        GetPrompt();
        DisplayPrompt();
        
        DisplayQuestionPrep();
        Countdown();
        Console.Clear();
        while ( currentTime < futureTime)
        {   
            currentTime = DateTime.Now;
            string question = GetQuestion();
            DisplayQuestion(question);
            Pause();

        }

        Pause();
        EndingMessage();
        Pause();
        
    }
}