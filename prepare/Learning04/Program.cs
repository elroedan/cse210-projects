using System;

class Program
{
    static void Main(string[] args)
    {
        Student fred = new Student("fred", "8768");
        string name = fred.GetName();
        string number = fred.GetNumber();
        fred.SetName("Joe");
        name = fred.GetName();
  

        
        Console.WriteLine(name);
        System.Console.WriteLine(number);
        // fred.SetName("fred III");
    }
}