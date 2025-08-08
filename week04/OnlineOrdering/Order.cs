using System;

public class Order
{
    private double _productPrice;
    private double _shippingPrice;
    private double _totalPrice;

    public List<Product> products = new List<Product>();

    // CONTAINS LIST OF PRODUCTS AND A CUSTOMER
    // CAN CALCULATE THE TOTAL COST OF THE ORDER
    // CAN RETURN A STRING FOR THE PACKING LABEL
    // CAN RETURN A STRING FOR THE SHIPPING LABEL
    // COMPANY IS BASED IN THE USA. IF LIVING IN USA, SHIPPING COST IS $5. IF LIVING ABROAD, IT'S $35.
    // PACKING LABEL SHOULD LIST THE NAME AND PRODUCT ID OF EACH PRODUCT IN THE ORDER
    // SHIPPING LABEL SHOULD LIST NAME AND ADDRESS OF CUSTOMER

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
        foreach (Product product in products)
        {
            product.DisplayProductInfo();
        }
    }
}