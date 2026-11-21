using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the first customer (USA)
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "New York",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        // Create the first order
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P001", 850.00m, 1));
        order1.AddProduct(new Product("Wireless Mouse", "P002", 25.00m, 2));
        order1.AddProduct(new Product("Keyboard", "P003", 45.00m, 1));

        // Create the second customer (International)
        Address address2 = new Address(
            "15 Admiralty Way",
            "Lagos",
            "Lagos State",
            "Nigeria"
        );

        Customer customer2 = new Customer("Boma Richards", address2);

        // Create the second order
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Smartphone", "P004", 500.00m, 1));
        order2.AddProduct(new Product("Headphones", "P005", 75.00m, 2));
        order2.AddProduct(new Product("Smart Watch", "P006", 120.00m, 1));

        // Display first order
        Console.WriteLine("================================");
        Console.WriteLine("ORDER 1");
        Console.WriteLine("================================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():F2}");

        // Display second order
        Console.WriteLine("\n================================");
        Console.WriteLine("ORDER 2");
        Console.WriteLine("================================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():F2}");
    }
}