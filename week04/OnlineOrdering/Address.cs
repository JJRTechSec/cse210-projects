using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    public string SetStreetAddress(string street)
    {
        _streetAddress = street;
        return _streetAddress;
    }

    public string SetCity(string city)
    {
        _city = city;
        return _city;
    }

    public string SetState(string state)
    {
        _stateOrProvince = state;
        return _stateOrProvince;
    }

    public string SetCountry(string country)
    {
        _country = country;
        return _country;
    }

    public bool GetDomesticOrNot()
    {
        string country = _country.ToLower();
        return country == "usa" || country == "us";
    }

    public string DisplayAddressInformation()
    {
        return $"{_streetAddress}\n{_city}\n{_stateOrProvince}\n{_country}";
    }
}