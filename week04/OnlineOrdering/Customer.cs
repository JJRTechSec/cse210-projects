using System;

public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public bool DomesticOrNot()
    {
        return true;
    }

    public string GetCustomerName()
    {
        return _customerName;
    }

    public string GetCustomerAddress()
    {
        return "";
    }
}