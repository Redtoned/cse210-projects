using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // --- Order 1: Customer in the USA ---
        Address address1 = new Address("123 Maple Street", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        List<Product> products1 = new List<Product>
        {
            new Product("Wireless Mouse", "P1001", 24.99, 2),
            new Product("Mechanical Keyboard", "P1002", 89.50, 1),
            new Product("USB-C Cable", "P1003", 9.99, 3)
        };

        Order order1 = new Order(products1, customer1);

        // --- Order 2: Customer outside the USA ---
        Address address2 = new Address("45 King's Road", "Toronto", "Ontario", "Canada");
        Customer customer2 = new Customer("Emily Tremblay", address2);

        List<Product> products2 = new List<Product>
        {
            new Product("Desk Lamp", "P2001", 34.75, 1),
            new Product("Notebook Set", "P2002", 12.25, 4)
        };

        Order order2 = new Order(products2, customer2);

        // Display results for both orders
        List<Order> orders = new List<Order> { order1, order2 };
        int orderNumber = 1;

        foreach (Order order in orders)
        {
            Console.WriteLine($"===== Order {orderNumber} =====");

            Console.WriteLine("\n--- Packing Label ---");
            Console.WriteLine(order.GetPackingLabel());

            Console.WriteLine("\n--- Shipping Label ---");
            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine("\n--- Total Price ---");
            Console.WriteLine($"${order.GetTotalPrice():0.00}");

            Console.WriteLine("\n");
            orderNumber++;
        }
    }
}
