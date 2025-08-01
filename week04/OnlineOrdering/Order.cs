using System;

public class Order
{
    private double _productPrice;
    private double _shippingPrice;
    private double _totalPrice;

    public List<string> products = new List<string>();

    public double SetProductPrice(double price)
    {
        _productPrice = price;
        return _productPrice;
    }

    public double SetShippingPrice(double price)
    {
        _shippingPrice = price;
        return _shippingPrice;
    }


    public double SetTotalPrice(double price)
    {
        _totalPrice = price;
        return _totalPrice;
    }


    public void DisplayPackingLabel()
    {

    }
}