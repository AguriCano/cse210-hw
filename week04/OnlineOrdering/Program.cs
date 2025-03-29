using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Online Ordering Program");

        // Creating products
        Product product1 = new Product("Laptop", 101, 1200, 2);
        Product product2 = new Product("Phone", 102, 800, 3);

        // Creating customer address
        Address address1 = new Address("1234 Elm Street", "Los Angeles", "California", "USA");
        Address address2 = new Address("5678 Oak Avenue", "Toronto", "Ontario", "Canada");

        // Creating customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Creating orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product1);

        // Displaying results
        Console.WriteLine("\nOrder 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: {order1.CalculateTotal()}");

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: {order2.CalculateTotal()}");
    }
}