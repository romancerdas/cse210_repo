using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");

        Address address1 = new Address("123 Fake St.", "Fake Town", "State of Fake", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Address address2 = new Address("456 Another Fake St.", "City of Fake", "Fakey-Fakerton", "Country of Fake");
        Customer customer2 = new Customer("Jane Doe", address2);

        Product product1 = new Product("Laptop", 1001, 799.99, 2);
        Product product2 = new Product("Mouse", 1002, 25.50, 5);
        Product product3 = new Product("Keyboard", 1003, 49.99, 3);
        Product product4 = new Product("Monitor", 1004, 199.99, 1);

        List<Product> list1 = new List<Product>();
        list1.Add(product1);
        list1.Add(product2);

        List<Product> list2 = new List<Product>();
        list2.Add(product3);
        list2.Add(product4);

        Order order1 = new Order(customer1, list1);
        Order order2 = new Order(customer2, list2);

        Console.WriteLine("Order 1:");
        Console.WriteLine($"Total Price: {order1.GetTotalPrice():F2}");
        Console.WriteLine();
        Console.WriteLine($"{order1.CreatePackingLabel()}");
        Console.WriteLine($"{order1.CreateShippingLabel()}");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Order 2:");
        Console.WriteLine($"{order2.GetTotalPrice():F2}");
        Console.WriteLine($"{order2.CreatePackingLabel()}");
        Console.WriteLine($"{order2.CreateShippingLabel()}");
    }
}