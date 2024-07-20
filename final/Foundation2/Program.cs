using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("345 Willow Ave","Richmond","VA", "USA");
        Customer customer1 = new Customer("Jacob Dean", address1);
        Order order1 = new Order(customer1);
        
        Product product1 = new Product("Fidget Spinner", 4 , 3, "111");
        Product product2 = new Product("Walkie Talkie", 15, 2, "222");

        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: {order1.GetTotalPrice()}");

        Address address2 = new Address("775 hill Ave","Dubhai","EU", "UnitedEmrites");
        Customer customer2 = new Customer("Gary Fry", address2);
        Order order2 = new Order(customer2);
        
        Product product3 = new Product("Rocket", 100 , 2, "111");
        Product product4 = new Product("Train Set", 30, 2, "222");

        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: {order2.GetTotalPrice()}");
    }
}