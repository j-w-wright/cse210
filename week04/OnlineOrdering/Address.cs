using System;

class Address
{
    public string _addressStreet;
    public string _addressCity;
    public string _addressState;
    public string _addressCountry;


    public Address(string addressStreet, string addressCity, string addressState, string addressCountry)
    {
        _addressStreet = addressStreet;
        _addressCity = addressCity;
        _addressState = addressState;
        _addressCountry = addressCountry;
    }
    public string AddressStreet
    {
        get { return _addressStreet; }
        set { _addressStreet = value; }
    }
    public string AddressCity
    {
        get { return _addressCity; }
        set { _addressCity = value; }
    }
    public string AddressState
    {
        get { return _addressState; }
        set { _addressState = value; }
    }
    public string AddressCountry
    {
        get { return _addressCountry; }
        set { _addressCountry = value; }
    }

    public bool IsUsa()
    {
        if (_addressCountry.ToLower() == "usa" || _addressCountry.ToLower() == "united states")
        {
            return true;
        }
        return false;
    }

    public string FullAddress()
    {
        return $"{_addressStreet}, {_addressCity}, {_addressState}, {_addressCountry}";
    }
}