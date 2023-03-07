


public abstract class Goal{

    int _point;
    string _title;
    string _description;


    public Goal(string title, string description, int point)
    {
        _title = title;
        _description = description;
        _point = point;
    }

    public void SetInformation()
    {
        System.Console.Write("What is the name of your goal? ");
        string title = Console.ReadLine();
        System.Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        System.Console.WriteLine("What is the amount of points associated with this goal? ");
        string number = Console.ReadLine();
        int point = int.Parse(number);

        _title = title;
        _description = description; 
        _point = point;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoint()
    {
        return _point;
    }

    public void SetPoint(int point)
    {
        _point += point;
    }

    public abstract string  GetInformation();
    

    public abstract string Save();
    
}