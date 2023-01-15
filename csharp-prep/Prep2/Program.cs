using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string value = Console.ReadLine();
        int grade = int.Parse(value);

        string letter;
        string decision = "Congratulations! You passed the class! ";
        switch (grade)
        {
            case >= 90:
                letter = "A";
                break;
            case >= 80:
                letter = "B";
                break;
            case >= 70:
                letter = "C";
                break;
            case >= 60:
                letter = "D";
                break;
            case <= 60:
                letter = "C";
                break;
        }

       if (grade < 70)
       {
            decision = "Please retake this class, You didn't pass! ";
       }

       Console.WriteLine($"Your grade is: {letter}"); 
       Console.WriteLine($"{decision}"); 
    }
}