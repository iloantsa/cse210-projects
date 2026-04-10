
using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Book", "B001", 10, 2));
        order1.AddProduct(new Product("Pen", "P002", 2, 5));

        Address address2 = new Address("45 King St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Notebook", "N003", 7, 3));
        order2.AddProduct(new Product("Bag", "B004", 25, 1));

        DisplayOrder(order1);
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalCost()}\n");
    }
}
