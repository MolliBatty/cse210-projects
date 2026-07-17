using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("24 Gumdrop Ln", "Candycane City", "Texas", "USA");
        Address address2 = new Address("Bass st", "Pondavia", "England", "UK"); 
    
        Customer customer1 = new Customer("Billy James", address1);
        Customer customer2 = new Customer("Harold Nicely", address2);

        Product product1 = new Product("Bananas", 12002, 0.83m, 2);
        Product product2 = new Product("Milk", 13001, 3.78m, 1);
        Product product3 = new Product("Coco-Cola", 15009, 2.89m, 12);
        Product product4 = new Product("Mens Shoes Black (12)", 19012, 14.35m, 2);
        Product product5 = new Product("Pasta", 17037, 1.87m, 2);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);

        order1.AddProduct(product1);
        order1.AddProduct(product4);

        order2.AddProduct(product2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"${order1.GetTotalCost()}");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"${order2.GetTotalCost()}");
        Console.WriteLine();


    }
}