using System;

class Program
{
    static void Main(string[] args)
    {
          List<string> verses = new List<string>
            { 
                "And it came to pass",
                "the house is blue",
                "the end"
            };


        Scripture scrip = new Scripture(verses);
        scrip.Display();

        string start= " ";
        while (start.ToLower() != "quit"){
            
            Console.Write("Please press Enter to continue or typ \"Quit\" to finish ");
            start = Console.ReadLine();

            scrip.HideWords(3);
            Console.Clear();
            scrip.HideWords(3);
            
            scrip.IsAllHidden();
        }
    }
}