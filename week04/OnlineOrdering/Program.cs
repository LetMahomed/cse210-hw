using System;

class Program
{
    static void Main(string[] args)
    {
        // USA
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "A100", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "B200", 25.50, 2));

        DisplayOrder(order1);

        // International
        Address address2 = new Address("45 Oxford Street", "London", "N/A", "UK");
        Customer customer2 = new Customer("Emily Brown", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "C300", 79.99, 1));
        order2.AddProduct(new Product("Keyboard", "D400", 49.99, 1));
        order2.AddProduct(new Product("USB Cable", "E500", 9.99, 3));

        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.CalculateTotalCost()}");
        Console.WriteLine("-----------------------------------");
    }
}
