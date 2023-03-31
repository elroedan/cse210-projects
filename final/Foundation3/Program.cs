using System;
class Program
{
    static void Main(string[] args)
    {
        List <Event> events = new List<Event>();
        int number = 1;
        List <string> menu = new List<string>()
        {
            "Create Event", "Display Event", "Quit"
        };
        System.Console.WriteLine("Welcome to the Event Generator: \n");

        int choice = 0;

        while (choice != 3)
        {
            
            foreach(string action in menu)
            {
                System.Console.WriteLine($"     {number}. {action}");
                number += 1;
            }
            number = 1;
            System.Console.Write("Choose an option: ");
            choice = int.Parse(Console.ReadLine());
            Console.Clear();


            switch(choice)
            {
                case 1:
                    System.Console.WriteLine("Event types:");
                    System.Console.WriteLine("      1. Lecture Event");
                    System.Console.WriteLine("      2. Outdoor Event");
                    System.Console.WriteLine("      3. Reception Event");
                    System.Console.Write("Choose an event: ");
                    int command = int.Parse(Console.ReadLine());
                    switch(command)
                    {
                        case 1:
                            LectureEvent lectureEvent = new LectureEvent();
                            lectureEvent.GetEventData();
                            events.Add(lectureEvent);
                            
                            break;
                        case 3: 
                            ReceptionEvent receptionEvent = new ReceptionEvent();
                            receptionEvent.GetEventData();
                            events.Add(receptionEvent);

                            break;

                        case 2: 
                            OutdoorEvent outdoorEvent = new OutdoorEvent();
                            outdoorEvent.GetEventData();
                            events.Add(outdoorEvent);
                            break;
                        
                    }
                        System.Console.WriteLine("Event Created");
                    break; 

                case 2:
                    System.Console.WriteLine("The following are the display types:");
                    System.Console.WriteLine("      1. Standard Description");
                    System.Console.WriteLine("      2. Full Description ");
                    System.Console.WriteLine("      3. Short Description");
                    System.Console.Write("Choose an option: ");
                    int displayChoice = int.Parse(Console.ReadLine());

                    Console.Clear();

                    switch(displayChoice)
                    {
                        case 1:
                            foreach(Event activity in events)
                            {
                                activity.DisplayStandardDetails();
                            }
                            break;

                        case 2:
                            foreach(Event activity in events)
                            {
                                activity.DisplayFullDetail();
                            }
                            break;

                        case 3:
                            foreach(Event activity in events)
                            {
                                activity.DisplayShortDescription();
                            }
                            break;
                    }
                    break;
            }
        }
    }
}