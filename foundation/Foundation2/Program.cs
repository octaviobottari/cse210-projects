using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Maple Street", "New York", "NY", "USA");
        Address address2 = new Address("456 Elm Avenue", "Toronto", "ON", "Canada");

        Customer customer1 = new Customer("Alice Johnson", address1);
        Customer customer2 = new Customer("Bob Smith", address2);

        Product product1 = new Product("Laptop", "A123", 1000.00m, 1);
        Product product2 = new Product("Mouse", "B456", 25.00m, 2);
        Product product3 = new Product("Keyboard", "C789", 45.00m, 1);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}
