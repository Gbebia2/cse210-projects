using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("246 Main St", "Los Angeles", "CA", "USA");
        Customer customer1 = new Customer("James Moore", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Laptop", 101, 999.99, 1);
        Product product2 = new Product("Mouse", 102, 49.99, 2);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}\n");

        Address address2 = new Address("357 Elm St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Ana Smith", address2);
        Order order2 = new Order(customer2);

        Product product3 = new Product("Keyboard", 103, 79.99, 1);
        Product product4 = new Product("Monitor", 104, 199.99, 1);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
    }
}