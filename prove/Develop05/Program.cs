using System;

// create seperate method for setting and getting the info. 
// use a for loop in the program to calculate the points. (Ask each goal there total points)
// when you create a goal add to the list. 
// when loading clearList to make space for the uplcoming file. 


class Program
{
    // private void AddtoList(Goal goal)
    // {
    //     _goals.Add(goal);
    // }
    static void Main(string[] args)
    {
        List<Goal> _goals = new List<Goal>();
        
        

        int choice = -1;
        while (choice !=6)
        {
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

                
                break;
                
        }
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
                goals.Add(simpleGoal);

            }
            else if (goalType == "Eternal")
            {
                EternalGoal eternalGoal = new EternalGoal();
                eternalGoal.SetInformation(data);
                goals.Add(eternalGoal);
            }
            else if (goalType == "Checklist")
            {        

                Goal checklistGoal = new ChecklistGoal();
                checklistGoal.SetInformation(data);
                goals.Add(checklistGoal);
            }
            
        }  
        
            // while loop in a  txt file 
            // then
            /*
            have it splitted by the type then add it to the goal 
            before adding have conditions to check which goal it is then create the goal and add to the list.
            search how to clear a list. clear the list then recreate thungs like menttioned above.
            */            


            // string title = parts[1];
            // int point = Int32.Parse(parts[2]);
            // string description = parts[3];
    }
    string GetFileName()
    {
        System.Console.WriteLine("What is the file name? (include the .txt)"); 
        string fileName = Console.ReadLine();
        return fileName;
    }
    string Save(List<Goal> goals) 
    {   
        System.Console.Write("Enter name of the file (Entry1.txt): ");
        string _fileName = System.Console.ReadLine();
        foreach (Goal goal in goals)
        {
            string save = goal.GetInformationSaved();
            using (StreamWriter writer = new StreamWriter(_fileName))
            {
                writer.WriteLine(save);
            } 
            // string _fileWritten = ("The entry has been written to the file.");
            
        }
        // System.Console.WriteLine(_fileWritten);
        
        


        return _fileName;

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
        System.Console.WriteLine("Which Type of goal would you like to create? ");
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
        System.Console.WriteLine("Which goals did you accomplished? ");
        string choice = Console.ReadLine();
        int accomplishedGoal = int.Parse(choice);

        return accomplishedGoal;
    }
    }
    
        /* 
    

    I need to know if it needs to be virtual?
    Also ask about the total point and each goal point 
    best way to keep track of that ?

*/
    

}

