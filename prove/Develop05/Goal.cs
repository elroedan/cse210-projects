


public abstract class Goal{

    private int _point = 0;
    private string _title;
    private string _description;
    private bool _completed = false;

    List<string> _goals = new List<string>();

/* This list is created to have 
 less console.writeline in the displaystartingMenu
*/


    public Goal(string title, string description, int point)
    {
        _title = title;
        _description = description;
        _point = point;
    }

    public abstract void SetInformation(string stringRep);


// This function gets informations from user and sets the variables

    public string GetTitle()
    {
        return _title;
    }

    public bool GetCompleted()
    {
        return _completed;
    }

    public void SetCompleted(bool completed)
    {
        _completed = completed;
    }
  
    public void SetDescription(string description)
    {
        _description = description;
    }
    public void SetTitle(string title)
    {
        _title = title;
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
        _point = point;
    }

    public abstract bool GetFinished();

    public virtual int GivePoint()
    {
     
     
        System.Console.WriteLine($"Congratulations! you have earned {GetPoint()} ");
        return GetPoint();
       

    }

    public virtual void SetInformation()
    {
        // title|desc|proint
        System.Console.Write("What is the name of your goal? ");
        string title = Console.ReadLine();
        System.Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        System.Console.Write("What is the amount of points associated with this goal? ");
        string number = Console.ReadLine();
        int point = int.Parse(number);

        _title = title;
        _description = description; 
        _point = point;
    }


    /*
    This function is supposed to return the title, desc, point
     
    */
    public abstract string  GetInformationSaved();
    public virtual string DisplayInformation()
    {
        string title = GetTitle();
        string description = GetDescription();

        // int point = GetPoint();
        if (GetFinished() == false)
        {
            return $" [] {title} ({description}) ";
        }
        else
        {
            return $" [X] {title} ({description}) ";
        }
    }
   
    public abstract string DisplayGoals();
   
    
    
}