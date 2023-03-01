

public class Menu {
    public int DisplayMenu () {

        System.Console.WriteLine("Menu Options:");
        System.Console.WriteLine("  1. Start breathing activity");
        System.Console.WriteLine("  2. Start reflecting activity");
        System.Console.WriteLine("  3. Start listing activity");
        System.Console.WriteLine("  4. Quit");

        System.Console.Write("Select a choice from menu: ");
        string _menuChoice = Console.ReadLine();
        int _choice = int.Parse(_menuChoice);

        return _choice;
    }
}