using System;

public class Product
{
    private string _productName;
    private int _productId;
    private double _productPrice;
    private int _productQuantity;
    private double _totalPrice;

    private double GetTotalProductPrice()
    {
        double _totalPrice = _productQuantity * _productPrice;
        return _totalPrice;
    }

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

    public void DisplayProductInfo()
    {
        Console.WriteLine($"Product: {_productName}; Product ID: {_productId}; Product Price: {_productPrice}; Quantity: { _productQuantity}; Total Price: {GetTotalProductPrice()}");
    }
}