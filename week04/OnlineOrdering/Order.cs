using System;
using System.Collections.Generic;

public class Order
{
    public List<Product> _products = new List<Product>();
    private Customer _customer;

    public void SetCustomer(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalPrice()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalProductPrice();
        }

        double shippingCost;
        if (_customer.IsDomestic())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        total += shippingCost;

        return total;
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine("PACKING LABEL:");

        foreach (Product product in _products)
        {
            product.DisplayProductInfo();
        }
        Console.WriteLine();
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine("SHIPPING LABEL: ");
        Console.WriteLine(_customer.GetShippingLabel());
        Console.WriteLine();
    }
}