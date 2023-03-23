using System;
class Program
{
    static void Main(string[] args)
    {
        List<Goal> _goals = new List<Goal>();
        int _totalPoint = 0;
    
        int choice = -1;
        while (choice !=6)
        {
        System.Console.WriteLine($"You have {GetTotalPoint()} points.");
        choice = DisplayStartingMenu();

        switch (choice)
        {

            case 1:
                int goal = DisplayGoalType();
                switch (goal) 
                {
                    case 1:
                        Goal simpleGoal = new SimpleGoal();
                        simpleGoal.SetInformation();
                        _goals.Add(simpleGoal);
                        
                        break;

                    case 2:
                        Goal eternalGoal = new EternalGoal();
                        eternalGoal.SetInformation();
                        _goals.Add(eternalGoal);

                       
                        break;

                    case 3:
                        Goal checkListGoal = new ChecklistGoal();
                        checkListGoal.SetInformation();
                        _goals.Add(checkListGoal);

                        break;

                }
                break;
            case 2:
                DisplayGoalInformation(_goals);
                break;

            case 3:
                Save(_goals);
                break;

            case 4:
                string fileName = GetFileName();
                Load(fileName, _goals);
                break;

            case 5:

                int accomplishedGoal = DisplayGoalFromRecord(_goals);
                Goal completedGoal = _goals[accomplishedGoal-1];
                completedGoal.GetFinished();
                int pointGained = completedGoal.GivePoint();
                SetTotalPoint(pointGained);

                System.Console.WriteLine($"You now have {GetTotalPoint()} points.");
                System.Console.WriteLine();
                
                break;
                
        }
    }

    void SetTotalPoint(int addPoint)
    {
        _totalPoint += addPoint;
    }

    int GetTotalPoint()
    {
        return _totalPoint;
    }
    int DisplayStartingMenu()
    {
        List<string> StartingMenu = new List<string>()
        {
            "Create New Goal", "List Goals", "Save Goals",
            "Load Goals", "Record Event", "Quit"
        };
        
        System.Console.WriteLine();
        System.Console.WriteLine("Menu Options:");

        for (int i = 0; i < StartingMenu.Count; i++){
            System.Console.WriteLine($" {i+1}. {StartingMenu[i]}");
        }

        System.Console.Write("Select a choice from the Menu: ");
        string choose = Console.ReadLine();
        int choice = int.Parse(choose);

        return choice;
    }

    void Load(string fileName, List<Goal> goals)
    
    {
        goals.Clear();
        // Read the file and display it line by line.  
        foreach (string line in System.IO.File.ReadLines(fileName))
        {          

            string[] parts = line.Split(":");
            string goalType = parts[0];
            string data = parts[1];
            if (goalType == "Simple")
            {
                SimpleGoal simpleGoal = new SimpleGoal();
                simpleGoal.SetInformation(data);
                // simpleGoal.GetCompleted();
                // int pointGained = simpleGoal.GivePoint();
                // SetTotalPoint(pointGained);
                goals.Add(simpleGoal);

            }
            else if (goalType == "Eternal")
            {
                EternalGoal eternalGoal = new EternalGoal();
                eternalGoal.SetInformation(data);
                // eternalGoal.GetCompleted();
                // int pointGained = eternalGoal.GivePoint();
                // SetTotalPoint(pointGained);
                goals.Add(eternalGoal);
            }
            else if (goalType == "Checklist")
            {        

                Goal checklistGoal = new ChecklistGoal();
                checklistGoal.SetInformation(data);
                // checklistGoal.GetCompleted();
                // int pointGained = checklistGoal.GivePoint();
                // SetTotalPoint(pointGained);
                goals.Add(checklistGoal);
            }
            
        }  
    }

    string GetFileName()
    {
        System.Console.Write("What is the file name? (Entry1.txt)"); 
        string fileName = Console.ReadLine();
        return fileName;
    }

    void Save(List<Goal> goals) 
    {   
        System.Console.Write("Enter name of the file (Entry1.txt): ");
        string _fileName = System.Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(_fileName))
        {
            
            foreach (Goal goal in goals)
            {
            string save = goal.GetInformationSaved();
            writer.WriteLine(save);
            }             
        }     
    }

    void DisplayGoalInformation(List<Goal> _goals)
    {

        for (int i = 0; i < _goals.Count; i++){
            Goal goal = _goals[i];
            string display = goal.DisplayInformation();

            System.Console.WriteLine($" {i+1}. {display}");
        }
        
    }
    
    int DisplayGoalType()
    {
        System.Console.WriteLine("The type of goals are: ");
        System.Console.WriteLine("  1. Simple Goal");
        System.Console.WriteLine("  2. Eternal Goal");
        System.Console.WriteLine("  3. Checklist Goal");
        System.Console.Write("Which Type of goal would you like to create? ");
        string type = Console.ReadLine();
        int goalType = int.Parse(type);

        return goalType;
    }

    int DisplayGoalFromRecord(List<Goal> goals)
    {
        System.Console.WriteLine("The goals are: ");
        for (int i = 0; i < goals.Count; i++){
            Goal goal = goals[i];
            string display = goal.DisplayGoals();

            System.Console.WriteLine($" {i+1}. {display}");

        }
        System.Console.Write("Which goals did you accomplished? ");
        string choice = Console.ReadLine();
        int accomplishedGoal = int.Parse(choice);

        return accomplishedGoal;
    }

}


}

