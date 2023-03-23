using System;

public class Order
{
    
    private List<Product> products = new List<Product>();
    private int _shippingCost = 5;
    private double _tax = 0.6;

    public Order ()
    {
        
    }

    public int ShippingCost
    {
        get {return _shippingCost; }
        set {_shippingCost = value; }
    }
    public double Tax
    {
        get {return _tax; }
        set {_tax = value; }
    }


    public double TotalCost(bool getcustomerlocation)
    {
        double totalCost = 0;
        foreach(Product product in products)
        {
            totalCost += product.TotalPrice();
        }
        if (getcustomerlocation == true)
        {
            return totalCost+ ShippingCost; 

        }
        else{
            ShippingCost = 35;
            return (totalCost +ShippingCost) * Tax;
        }
        // Right a condition that calculates total cost with shipping.
    }

    public void PackingLabel()
    {   
        System.Console.WriteLine("Packing Label:");
        System.Console.WriteLine("     Product Name -- ProductId");
        foreach(Product product in products)
        {
            System.Console.WriteLine($"     {product.ProductName} -- {product.ProductId}");
        }
    }

    public void ShippingLabel(Customer customer)
    {
        System.Console.WriteLine("Shipping Label");
        System.Console.WriteLine($"     Customer Name: {customer.CustomerName}  ");
        System.Console.WriteLine($"     {customer.DisplayCustomerAddress} ");
    }

    public void DisplayProducts()
    {
        System.Console.WriteLine("Items in list:");
        for(int i = 0; i < products.Count(); i++ )
        {
            System.Console.WriteLine($"{i+1} {(products[i].DisplayProduct())}"); 
        }
    }
    public void GetProductInfo()
    {
        Product product = new Product();
        System.Console.Write("Enter product Name: ");
        product.ProductName = Console.ReadLine();
        System.Console.Write($"Enter the product Id for {product.ProductName}: ");
        product.ProductId = int.Parse(Console.ReadLine());
        System.Console.Write($"Enter the price for {product.ProductName}: ");
        product.Price = double.Parse(Console.ReadLine());
        System.Console.Write($"How many {product.ProductName} would you like? ");
        product.Quantity = int.Parse(Console.ReadLine());

        products.Add(product);            
    }

    public void RemoveProduct()
    {
        System.Console.Write("Which item would you like to remove? ");
        int removingIndex = int.Parse(Console.ReadLine());
        System.Console.WriteLine($"{products[removingIndex].ProductName} Removed");
        products.RemoveAt(removingIndex - 1);
    }

}