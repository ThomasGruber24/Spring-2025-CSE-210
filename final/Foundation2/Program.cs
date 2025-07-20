using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Flynn's Arcade", "Center City", "California", "USA");
        Customer customer1 = new Customer("Kevin Flynn", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Space Paranoids", "SP001", 19.99, 2));
        order1.AddProduct(new Product("Tron Light Cycle", "LC002", 29.99, 1));

        Console.WriteLine("Order Details:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.GetTotalCost()}");
        Console.WriteLine();

        Address address2 = new Address("End of Line Club", "Grid City", "Grid", "The Grid");
        Customer customer2 = new Customer("Zuse", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Identity Disc", "ID003", 15.00, 1));
        order2.AddProduct(new Product("Exsplosives", "EX004", 50.00, 3));

        Console.WriteLine("Order Details:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order2.GetTotalCost()}");
        Console.WriteLine("End of Line, man.");
        Console.WriteLine();
    }
}