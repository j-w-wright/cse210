using System;
using System.Collections.Generic;

class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();



    public Order(Customer customer, Product product)
    {
        _customer = customer;
        AddProduct(product);
    }

    public Customer Customer
    {
        get { return _customer; }
        set { _customer = value; }
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public List<Product> Products
    {
        get { return _products; }
    }

    public int ProductTotal()
    {
        int total = 0;
        foreach (var product in _products)
        {
            total += product.TotalCost();
        }
        return total;
    }

    public int ShippingCost()
    { 
        return _customer.Address.IsUsa() ? 5 : 35; // Shipping cost based on address
    }

    public int TotalCost()
    {
        return ProductTotal() + ShippingCost(); // Total cost includes product total and shipping cost
    }


    //public int TotalCost()
    //{
    //    int total = 0;
    //    foreach (var product in _products)
    //    {
    //        total += product.TotalCost();
    //    }
    //    if (_customer.Address.IsUsa())
    //    {
    //        total += 5; // Add shipping cost for USA
    //    }
    //    else
    //    {
    //        total += 15; // Add shipping cost for international
    //    }
    //    return total;
    //}

    // Display order information: customer name and total cost
    public string DisplayOrderInfo()
    {
        return $"Order for: {_customer.FullName()} Total Cost: ${TotalCost()}";
    }

    // Shipping label: customer name and address
    public string GetShippingLabel()
    {
        return $"Ship To:\n{_customer.FullName()}\n{_customer.Address.FullAddress()}";
    }

    // Packing label: product name and id for each product
    public string GetPackingLabel()
    {
        string label = "Packing List:\n";
        foreach (var product in _products)
        {
            label += $"- {product.Name} (ID: {product.Id})\n";
        }
        return label;
    }
}
