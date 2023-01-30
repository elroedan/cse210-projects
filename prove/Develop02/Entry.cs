using System;

public class Entry
{
  public string _date;
  public string _entry;
  public DateTime theCurrentTime = DateTime.Now; 


 
  public string WriteEntry(string prompt) {
    string dateText = theCurrentTime.ToShortDateString();   
    System.Console.WriteLine($"{prompt}");
    _entry = System.Console.ReadLine();
    return $"{dateText}, {_entry}"; 
  }

  public void DisplayEntry(string text) {

    System.Console.WriteLine(text);

  }


}