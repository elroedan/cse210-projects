using System;

class Program
{
    static void Main(string[] args)
    {   
        List<Activity> activities = new List<Activity>();
        int choice = 0;
        System.Console.WriteLine("Welcome to the Activity Tracker!");
        while (choice != 3)
        {
        System.Console.WriteLine();
        System.Console.WriteLine("Select a choice: ");
        System.Console.WriteLine("1. Create an activity");
        System.Console.WriteLine("2. Display Activity");
        System.Console.WriteLine("3.Quit");
        System.Console.Write("Enter Command: ");

        choice = int.Parse(Console.ReadLine());
        Console.Clear();

        switch(choice)
        {
            case 1:
                System.Console.WriteLine();
                System.Console.WriteLine("Select Activity you Accomplished: ");
                System.Console.WriteLine("      1. Running Activity");
                System.Console.WriteLine("      2. Swimming Activity");
                System.Console.WriteLine("      3. Bike Activity");
                System.Console.Write("Enter option: ");
                int command = int.Parse(Console.ReadLine());
                Console.Clear();

                switch(command)
                {
                    case 1:     
                        RunningActivity runningActivity = new RunningActivity();
                        runningActivity.GetActivityData();
                        activities.Add(runningActivity);

                        break;

                    case 2: 

                        SwimmingActivity swimmingActivity = new SwimmingActivity();
                        swimmingActivity.GetActivityData();
                        activities.Add(swimmingActivity);

                        break;
                    
                    case 3: 

                        BikeActivity bikeActivity = new BikeActivity();
                        bikeActivity.GetActivityData();
                        activities.Add(bikeActivity);
                        break;
                }
                Console.Clear();
                break;

            case 2:
                foreach(Activity activity in activities)
                {
                    System.Console.WriteLine(activity.GetSummary());    
                    System.Console.WriteLine();
                }

                break;
        }
        }
    }
}