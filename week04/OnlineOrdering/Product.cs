using System;

public class Product
{
    private string _productName;
    private int _productId;
    private double _productPrice;
    private int _productQuantity;

    public double TotalProductPrice()
    {
        double totalPrice = _productQuantity * _productPrice;
        return totalPrice;
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
}