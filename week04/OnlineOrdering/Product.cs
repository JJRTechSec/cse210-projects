using System;

public class Product
{
    private string _productName;
    private int _productId;
    private double _productPrice;
    private int _productQuantity;

    public string SetProductName(string productName)
    {
        _productName = productName;
        return _productName;
    }

    public int SetProductId(int id)
    {
        _productId = id;
        return _productId;
    }

    public double SetProductPrice(double price)
    {
        _productPrice = price;
        return _productPrice;
    }

    public int SetProductQuantity(int quantity)
    {
        _productQuantity = quantity;
        return _productQuantity;
    }

    public double GetTotalProductPrice()
    {
        return _productQuantity * _productPrice;
    }

    public void DisplayProductInfo()
    {
        Console.WriteLine($"Product: {_productName}; Product ID: {_productId}; Quantity: {_productQuantity}\nUnit Price: {_productPrice}; Total: ${GetTotalProductPrice()}");
    }
}