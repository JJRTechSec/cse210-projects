using System;

public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public string SetCustomerName(string name)
    {
        _customerName = name;
        return _customerName;
    }

    public void SetCustomerAddress(Address address)
    {
        _customerAddress = address;
    }

    public bool IsDomestic()
    {
        return _customerAddress.GetDomesticOrNot();
    }

    public string GetShippingLabel()
    {
        return $"{_customerName}\n{_customerAddress.DisplayAddressInformation()}";
    }
}