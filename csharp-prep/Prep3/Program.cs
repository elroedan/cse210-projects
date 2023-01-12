using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Let's play a guessing game!");
        
        Random input = new Random();
        int number = input.Next(1, 40);

        
        int magicNumber = 0;

        int retry = 0;
        while (!(number == magicNumber))
        {

        Console.WriteLine("What is your guess? ");
        string guess = Console.ReadLine();
        magicNumber = int.Parse(guess);
        if (magicNumber > number)
        {    
            Console.WriteLine("Guess lower");
        }
        
        else
        { 
            Console.WriteLine("Guess higher");
        }
        retry += 1;

        }
        Console.WriteLine("You guessed the number!!");
        Console.WriteLine("It took you "+ (retry) + " guesses");
    }
}