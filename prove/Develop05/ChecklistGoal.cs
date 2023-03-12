

public class ChecklistGoal : Goal
{
    int _numberOfTimes;
    int _bonusPoints = 0;

    public ChecklistGoal() : base("CheckList", "N/A", 0)
    {
        
    }

    public int GetnumberOfTimes()
    {
        return _numberOfTimes;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public  void SetnumberOfTimes(int count)
    {
        _numberOfTimes = count;
    }

    public void SetBonusPoints(int bonus)
    {
        _bonusPoints = bonus;
    }

    

    public override void SetInformation()
    {
        System.Console.Write("What is the name of your goal? ");
        string title = Console.ReadLine();
        System.Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        System.Console.Write("What is the amount of points associated with this goal? ");
        string pointString = Console.ReadLine();
        int point = int.Parse(pointString);
        System.Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        string number = Console.ReadLine();
        int numberOfTimes = int.Parse(number);

        System.Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        string many = Console.ReadLine();
        int bonus = int.Parse(many);

        SetTitle(title);
        SetDescription(description);
        SetPoint(point);
        _bonusPoints += bonus;
        _numberOfTimes = numberOfTimes;
    }

    public override string GetInformationSaved()
    {
        string title = GetTitle();
        string description = GetDescription();
        int point = GetPoint();
        int numberOfTimes = GetnumberOfTimes();
        int bonusPoint = GetBonusPoints();
        

        return $"Checklist:{title}|{point}|{description}|{numberOfTimes}|{bonusPoint}";
    }


    public override void SetInformation(string stringRep)
    {
            string[] parts = stringRep.Split("|");
           string title = parts[0];
           string pointString = parts[1];
           int point = int.Parse(pointString);
           string description = parts[2];
           string numberOfTimes = parts[3];
           int count = int.Parse(numberOfTimes);
           string bonus = parts[4];
           int bonusPoint = int.Parse(bonus);

           SetTitle(title);
           SetDescription(description);
           SetPoint(point);
           SetBonusPoints(bonusPoint);
           SetnumberOfTimes(count);
    }

    public override string DisplayInformation()
    {
        string title = GetTitle();
        string description = GetDescription();
        // int point = GetPoint();

        return $" [] {title} ({description}) -- currently completed: /{_numberOfTimes} ";
    }

    public override bool GetFinished()
    {
        throw new NotImplementedException();
    }

    public override string DisplayGoals()
    {
        return GetTitle();
    }

}