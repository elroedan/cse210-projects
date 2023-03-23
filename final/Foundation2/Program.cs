using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();
        System.Console.WriteLine("Welcome to the Online Shopping!");
        int choice = 0;
        while(choice != 4) 
        {
            System.Console.WriteLine("1. Start Order");      
            System.Console.WriteLine("2. Place Order");
            System.Console.WriteLine("3. Display Order");   
            System.Console.WriteLine("4. Quit");   
            System.Console.WriteLine();
            System.Console.WriteLine("Enter a command: ");
            choice = int.Parse(Console.ReadLine());

            string menuChoice = "0";
            switch(choice)
            {
               
                case 1:
                    Order order = new Order();
                    while (menuChoice != "")
                    {
                        System.Console.WriteLine("Menu: ");
                        System.Console.WriteLine("1. Add item ");
                        System.Console.WriteLine("2. Display cart");
                        System.Console.WriteLine("3. Remove item");
                        System.Console.WriteLine("(Press enter when finished) Enter a command: ");
                        menuChoice = Console.ReadLine();

                        
                        switch(menuChoice)
                        {
                            case "1":
            
                                order.GetProductInfo();
                                break;
                            
                            case "2":
                                order.DisplayProducts();
                                break;

                            case "3":
                                order.RemoveProduct();
                                break;
                        }
                    }
                    orders.Add(order);
                    break;

                case 2:
                    
                    break;

            }


            
        }
        System.Console.WriteLine("");        
    }
        
}