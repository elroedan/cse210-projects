using System;


class Menu
{
  int _enter;

  public Menu() {

  }
  public void DisplayMenu() {
    System.Console.WriteLine("Please select one of the folllowing choice:");
    System.Console.WriteLine("1. Write");
    System.Console.WriteLine("2. Display");
    System.Console.WriteLine("3.Load");
    System.Console.WriteLine("4. Save");
    System.Console.WriteLine("5. Quit");
  }

public int OpenJournal() {
    System.Console.Write("Enter Choice: ");
        string choice = Console.ReadLine();
        _enter = int.Parse(choice);

    return _enter;
 
}
}