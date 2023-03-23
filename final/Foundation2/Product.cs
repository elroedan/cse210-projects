using System;

public class Product
{
    private string _productName;
    private double _price;
    private int _productId;
    private int _quantity;

    public Product()
    {
        
    }
    public string ProductName
    {
        get {return _productName; }
        set {_productName = value; }
    }   

    public double Price
    {
        get {return _price; }
        set {_price = value; }
    }

    public int Quantity
    {
        get {return _quantity; }
        set {_quantity = value; }
    }

    public int ProductId
    {
        get {return _productId; }
        set {_productId = value; }
    }

    public double TotalPrice()
    {
        return Price * Quantity;
    }
    
    public string DisplayProduct()
    {
        return $"{ProductName} -{Price}$ -{Quantity} QTY";
    }
}