using System;

namespace OnlineOrdering;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main Street", "Seattle", "WA", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Wireless Mouse", "P101", 25.50, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "P204", 89.99, 1));
        order1.AddProduct(new Product("USB-C Cable", "P305", 12.00, 3));

        Address address2 = new Address("Av. Larco 456", "Miraflores", "Lima", "Peru");
        Customer customer2 = new Customer("Carlos Mendoza", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("27-inch Monitor", "P809", 299.99, 1));
        order2.AddProduct(new Product("HDMI Cable", "P302", 15.00, 2));

        Console.WriteLine("==================================================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():F2}\n");

        // Display Order 2
        Console.WriteLine("==================================================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():F2}\n");
    }
}