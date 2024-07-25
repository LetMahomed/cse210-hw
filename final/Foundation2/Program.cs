using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address address1 = new Address("Champ de Mars, 5 Avenue Anatole France", "Paris", "75007", "France");
        Customer customer1 = new Customer("Luiza", address1);
        List<Product> productsList1 = new List<Product>();

        Product p1001 = new Product("Pen", "A234", 1.99, 3);
        Product p1002 = new Product("Eraser", "A987", 0.99, 3);
        Product p1003 = new Product("Pencil", "A568", 1.99, 9);

        productsList1.Add(p1001);
        productsList1.Add(p1002);
        productsList1.Add(p1003);

        Order order1 = new Order(productsList1, customer1);

        Console.WriteLine("Order Number: 1");
        order1.DisplayResults();
        Console.WriteLine();

        // Order 2
        Address address2 = new Address("Bennelong Point", "Sydney", "NSW 2000", "Australia");
        Customer customer2 = new Customer("Luis", address2);
        List<Product> productsList2 = new List<Product>();

        Product p2001 = new Product("Bed", "B567", 59.99, 3);
        Product p2002 = new Product("Sheet", "B234", 19.99, 3);
        Product p2003 = new Product("Pillow", "B786", 12.50, 3);

        productsList2.Add(p2001);
        productsList2.Add(p2002);
        productsList2.Add(p2003);

        Order order2 = new Order(productsList2, customer2);

        Console.WriteLine("Order Number: 2");
        order2.DisplayResults();
        Console.WriteLine();

        // Order 3
        Address address3 = new Address("Liberty Island", "New York", "NY 10004", "USA");
        Customer customer3 = new Customer("Leticia", address3);
        List<Product> productsList3 = new List<Product>();

        Product p3001 = new Product("Computer", "C478", 1899.99, 2);
        Product p3002 = new Product("Headset", "C789", 389.99, 2);

        productsList3.Add(p3001);
        productsList3.Add(p3002);

        Order order3 = new Order(productsList3, customer3);

        Console.WriteLine("Order Number: 3");
        order3.DisplayResults();
        Console.WriteLine();
    }
}