using System;
using System.Numerics;

class Product
{
    private string _name;
    private string _id;
    private int _price;
    private int _quantity;

    public Product(string name, string id, int price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public string Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public int Price
    {
        get { return _price; }
        set { _price = value; }
    }
    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; }
    }

    public int TotalCost()
    {
      return _price * _quantity;
    }
}