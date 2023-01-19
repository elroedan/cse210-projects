using System;


// Shopping cart program 
/* 
1) Add itme 
2) display 
3) total 
4) remove
5) quit
*/
class Program
{
    static void Main(string[] args)
    {
        
        List<string> items = new List<string>();
        List<float> prices = new List<float>();

        bool done = false;
        while (!done)
        {
            /*
switch(expression) 
{
  case x:
    // code block
    break;
  case y:
    // code block
    break;
  default:
    // code block
    break;
}
*/
            /*
            switch (choice)
            {
                case 1:
                    AddItem(items, prices);
                    break;
                case 2:
                    Display(items, prices);
                    break;

                case 5:
                    done = false;
                    break;
            }
            */
            Displaymenu();
            int choice = GetChoice();

            if (choice == 1)
            {
                AddItem(items, prices);
            }

            else if (choice == 2)
            {
                Diplay(items, prices);
            }

            else if (choice == 3)
            {
                
            }
            else if (choice == 4)
            {

            }
            else if (choice == 5)
            {
                done = true;
            }

        }

    }
    static void Displaymenu()
    {
        System.Console.WriteLine("1) Add item");
        System.Console.WriteLine("2) Display");
        System.Console.WriteLine("3) Total");
        System.Console.WriteLine("4) Remove");
        System.Console.WriteLine("5) Quit");
    }

    static int GetChoice()
    {
        System.Console.WriteLine("Enter Choice: ");
        string choice = Console.ReadLine();
        int answer = int.Parse(choice);
        return answer;
    }

    static void AddItem(List<string> items, List<float> prices)
    {
        System.Console.Write("Enter item: ");
        string item = Console.ReadLine();

        System.Console.Write("Enter price: ");
        string amount = Console.ReadLine();
        float price = float.Parse(amount);

        items.Add(item);
        prices.Add(price);
    }
    static void Diplay(List<string> items, List<float> prices)
    {
        for (int i = 0; i < items.Count; i ++)
        {
            System.Console.WriteLine($"{items[i]}: {prices[i]}");
        }
        System.Console.WriteLine("");
    }
}