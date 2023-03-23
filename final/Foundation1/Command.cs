

public class Command
{
    public Command()
    {

    }

    public int DisplayMenu()
    {
        System.Console.WriteLine("\n\n\n\n");
        System.Console.WriteLine("1. Create a video");
        System.Console.WriteLine("2. Display");
        System.Console.WriteLine("3. Remove a video");
        System.Console.WriteLine("4. Quit");
        System.Console.Write("Enter a command: ");
        string choice = Console.ReadLine();
        int command = int.Parse(choice);
        System.Console.WriteLine();
        Console.Clear();

        return command;
    }

    public int GetVideoOption()
    {
        System.Console.WriteLine();
        System.Console.WriteLine("1. Add a comment");
        System.Console.WriteLine("2. return to menu");
        System.Console.Write("Enter a command: ");
        string choice = Console.ReadLine();
        int command = int.Parse(choice);
        System.Console.WriteLine();
        Console.Clear();
        return command;
    }

    
}