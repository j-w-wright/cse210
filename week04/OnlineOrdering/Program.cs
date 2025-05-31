using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Kept the original message for testing.
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine();

        // Create list of products
        List<Product> products = new List<Product>();
        {
            products.Add(new Product("Macbook", "1234", 1000, 1));
            products.Add(new Product("iPhone", "5678", 800, 1));
            products.Add(new Product("iPad", "91011", 600, 1));
            products.Add(new Product("Apple Watch", "121314", 400, 1));
            products.Add(new Product("AirPods", "151617", 200, 1));
            products.Add(new Product("Apple TV", "181920", 150, 1));
        }

        // Create addresses instances
        Address address1 = new Address("123 Main St", "Seattle", "WA", "USA");
        Address address2 = new Address("7 Florida Dr", "Exeter", "", "England");
        Address address3 = new Address("789 Rio Verde C", "Tijuana", "BC", "Mexico");
        Address address4 = new Address("101 Pine St", "Santa Barbara", "CA", "USA");
        Address address5 = new Address("202 Maple St", "Vancouver", "BC", "Canada");

        // Create customers instances
        Customer cust1 = new Customer("Leo", "Marvin", address1);
        Customer cust2 = new Customer("Bob", "Wiley", address2);
        Customer cust3 = new Customer("Wesley", "Black", address3);
        Customer cust4 = new Customer("Shawn", "Spencer", address4);
        Customer cust5 = new Customer("Burton", "Guster", address5);

// Used for testing the code.
        //foreach (Customer customer in new List<Customer> { cust1, cust2, cust3, cust4, cust5 })
        //{
        //    Console.WriteLine($"Name: {customer.FullName()}\nAddress: {customer.Address.FullAddress()}");
        //}

        Order order1 = new Order(cust1, products[0]);
        order1.AddProduct(products[1]);
        Order order2 = new Order(cust2, products[2]);
        order2.AddProduct(products[3]);
        Order order3 = new Order(cust3, products[4]);
        order3.AddProduct(products[5]);
        Order order4 = new Order(cust4, products[0]);
        order4.AddProduct(products[1]);
        Order order5 = new Order(cust5, products[2]);
        order5.AddProduct(products[3]);
        
        List<Order> orders = new List<Order> {order1, order2, order3, order4, order5};

        foreach (Order order in orders)
        {
            Console.WriteLine(order.DisplayOrderInfo());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine();
        }

        Console.WriteLine();
        
        Console.ReadKey();

    }
}