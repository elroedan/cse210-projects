using System;

class Program
{
    static void Main(string[] args)
    {
        List<float> numbers = new List<float>();
        float sum = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        
        bool loop = true;
        while (loop == true)
        {
            
        Console.Write("Enter number: ");
        string input = Console.ReadLine();
        float userInput = float.Parse(input);
        numbers.Add(userInput);
        
        if (userInput == 0)
        {
            numbers.Remove(numbers.Last());
            loop = false;
        }
        
        }

        foreach (float number in numbers)
        {
            sum += number;
            
        }
        int listLength = numbers.Count; 
        float average = (sum / listLength); 
        numbers.Sort();

        Console.WriteLine("The sum is: "+ (sum));
        Console.WriteLine("The average is: "+ (average));
        Console.WriteLine("The smallest number is: "+ numbers[0]);
        Console.WriteLine("The largest number is: "+ numbers.Last());

        foreach (float sorted in numbers)
        {
            Console.WriteLine(sorted);
        }
    }
}