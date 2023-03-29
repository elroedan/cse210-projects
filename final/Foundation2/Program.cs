using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();
        int choice = 0;

        Customer person = new Customer();
        System.Console.WriteLine("Welcome! please create account to start. \n\n\n");
        System.Console.Write("Please Enter your name: ");
        person.CustomerName = Console.ReadLine();
        person.GetCustomerAddress();
        Console.Clear();

        while(choice != 4) 
        {
            System.Console.WriteLine("Welcome to the Online Shopping!");
            System.Console.WriteLine("1. Start Order");      
            System.Console.WriteLine("2. Place Order");
            System.Console.WriteLine("3. Display Orders");   
            System.Console.WriteLine("4. Quit");   
            System.Console.WriteLine();
            System.Console.Write("Enter a command: ");
            choice = int.Parse(Console.ReadLine());
            Console.Clear();

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
                        System.Console.WriteLine("4. Total cost");
                        System.Console.Write("(Press enter when finished) Enter a command: ");
                        menuChoice = Console.ReadLine();
                        Console.Clear();
                        
                        switch(menuChoice)
                        {
                            case "1":
            
                                order.GetProductInfo();
                                Console.Clear();
                                break;
                            
                            case "2":
                                order.DisplayProducts();
                                break;

                            case "3":
                                order.RemoveProduct();

                                break;
                            
                            case "4":
                                Console.Clear();
                                System.Console.WriteLine($"SubTotal: {((order.TotalCost(person.GetCustomerLocation()) / order.Tax) - order.ShippingCost).ToString("F")}");
                                System.Console.WriteLine($"Shipping Cost: {order.ShippingCost}");  
                                System.Console.WriteLine($"Tax: {order.Tax}");
                                System.Console.WriteLine($"Total: {order.TotalCost(person.GetCustomerLocation()).ToString("F")} ");  
                                break;
                            default:
                                Console.WriteLine("Invalid command. Please try again.\n");
                                break;
                        }
                    }
                    orders.Add(order);
                    break;

                case 2:
                    foreach(Order customerOrder in orders)
                    {
                        customerOrder.PackingLabel();
                    }

                    break;

                case 3: 
                    foreach(Order customerOrder in orders)
                    {
                        customerOrder.ShippingLabel(person);
                    }
                    break;
                case 4:
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid command. Please try again.\n");
                    break;
            }


            
        }
    }
        
}