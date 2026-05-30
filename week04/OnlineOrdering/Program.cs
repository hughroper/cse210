using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address(
            "123 Main St",
            "White Rock",
            "NM",
            "USA"
        );

        Customer customer1 = new Customer(
            "Hugh Roper",
            address1
        );

        Order order1 = new Order(customer1);

        Product product1 = new Product(
            "Mesh Radio",
            "Lilygo T-Deck",
            89.99,
            2
        );

        Product product2 = new Product(
            "Heltec v4",
            "V-004",
            24.99,
            1
        );

        Address address2 = new Address(
            "12 Dhanmondi Road",
            "Dhaka",
            "Dhaka Division",
            "Bangladesh"
        );

        Customer customer2 = new Customer(
            "Rick Runer",
            address2
        );

        Order order2 = new Order(customer2);

        Product product3 = new Product(
            "Heltec V4",
            "HV4-001",
            29.99,
            2
        );

        Product product4 = new Product(
            "915 MHz Antenna",
            "RKL-915",
            12.99,
            1
        );

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine(order1.GetTotalCost());

        Console.WriteLine();

        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();

        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine(order2.GetTotalCost());



    }
}