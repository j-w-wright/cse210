using System;


class Customer
{
    private string _firstName;
    private string _lastName;
    private Address _address;


    public Customer(string firstName, string lastName, Address address)
    {
        _firstName = firstName;
        _lastName = lastName;
        _address = address;
    }

    public Address Address
    {
        get { return _address; }
        set { _address = value; }
    }
    public string FirstName
    {
        get { return _firstName; }
        set { _firstName = value; }
    }
    public string LastName
    {
        get { return _lastName; }
        set { _lastName = value; }
    }
    public string FullName()
    {
        return $"{_firstName} {_lastName}";
    }
}