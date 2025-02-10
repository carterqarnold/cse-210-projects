using System;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
            // Order 1
        List<double> o1costs = new List<double>();
        Order order1 = new Order();

        Product o1product1 = new Product("Chair", "1A002", 34.33, 3);
        Product o1product2 = new Product("Couch", "1B002", 133.59, 2);
        Product o1product3 = new Product("TV", "5G02", 99.99, 1);


        Customer customer1 = new Customer("Carter");
        Customer.Address address1 = new Customer.Address("1234 Bluebird way", "Denver", "Colorado", "United States of America");
        
        o1costs.Add(o1product1.TotalProductPrice());
        o1costs.Add(o1product2.TotalProductPrice());
        o1costs.Add(o1product3.TotalProductPrice());

        order1.AddProducts(o1product1.ProductString());
        order1.AddProducts(o1product2.ProductString());
        order1.AddProducts(o1product3.ProductString());

        Console.WriteLine();
        Console.WriteLine("Shipping Label: ");

        order1.ShippingLabel(customer1.GetName(), address1.FullAddress());
        Console.WriteLine();
        Console.WriteLine("Packing Label: ");

        order1.PackingLabel();
        Console.WriteLine();

        order1.ShippingCost(customer1.InUSA(address1.InUSAOrNot()));
        order1.TotalCost(o1costs);
        Console.WriteLine();

            // Order 2
        List<double> o2costs = new List<double>();
        Order order2 = new Order();

        Product o2product1 = new Product("Box", "1D002", 11.33, 3);
        Product o2product2 = new Product("Tire", "1K002", 333.59, 4);
        Product o2product3 = new Product("Cup", "5F02", 9.00, 1);


        Customer customer2 = new Customer("Bridger Arnold");
        Customer.Address address2 = new Customer.Address("5678 Redbird Drive", "Worland", "Wyoming", "America");
        
        o2costs.Add(o2product1.TotalProductPrice());
        o2costs.Add(o2product2.TotalProductPrice());
        o2costs.Add(o2product3.TotalProductPrice());

        order2.AddProducts(o2product1.ProductString());
        order2.AddProducts(o2product2.ProductString());
        order2.AddProducts(o2product3.ProductString());

        Console.WriteLine("Shipping Label: ");

        order2.ShippingLabel(customer2.GetName(), address2.FullAddress());
        Console.WriteLine();
        Console.WriteLine("Packing Label: ");

        order2.PackingLabel();
        Console.WriteLine();

        order2.ShippingCost(customer2.InUSA(address2.InUSAOrNot()));
        order2.TotalCost(o2costs);
        Console.WriteLine();

            // Order 3
        List<double> o3costs = new List<double>();
        Order order3 = new Order();

        Product o3product1 = new Product("3D Printer", "2H001", 311.33, 1);
        Product o3product2 = new Product("Hat", "3K001", 3.59, 2);
        Product o3product3 = new Product("Plate", "2R002", 9.00, 4);


        Customer customer3 = new Customer("Arnold Smith");
        Customer.Address address3 = new Customer.Address("5059 Greenbird Ave", "Green", "Greenland", "None");
        
        o3costs.Add(o3product1.TotalProductPrice());
        o3costs.Add(o3product2.TotalProductPrice());
        o3costs.Add(o3product3.TotalProductPrice());

        order3.AddProducts(o3product1.ProductString());
        order3.AddProducts(o3product2.ProductString());
        order3.AddProducts(o3product3.ProductString());

        Console.WriteLine("Shipping Label: ");

        order3.ShippingLabel(customer3.GetName(), address3.FullAddress());
        Console.WriteLine();
        Console.WriteLine("Packing Label: ");

        order3.PackingLabel();
        Console.WriteLine();
        
        order3.ShippingCost(customer3.InUSA(address3.InUSAOrNot()));
        order3.TotalCost(o3costs);
        Console.WriteLine();

            // Order 4
        List<double> o4costs = new List<double>();
        Order order4 = new Order();

        Product o4product1 = new Product("Bed", "1G032", 134.43, 1);
        Product o4product2 = new Product("Teddy Bear", "1B0T3", 3.63, 3);
        Product o4product3 = new Product("Cow", "10N02", 800.00, 1);


        Customer customer4 = new Customer("Alexander Grandala");
        Customer.Address address4 = new Customer.Address("1048 Purplebird St", "Paris", "France", "None");
        
        o4costs.Add(o4product1.TotalProductPrice());
        o4costs.Add(o4product2.TotalProductPrice());
        o4costs.Add(o4product3.TotalProductPrice());

        order4.AddProducts(o4product1.ProductString());
        order4.AddProducts(o4product2.ProductString());
        order4.AddProducts(o4product3.ProductString());

        Console.WriteLine("Shipping Label: ");

        order4.ShippingLabel(customer4.GetName(), address4.FullAddress());
        Console.WriteLine();
        Console.WriteLine("Packing Label: ");

        order4.PackingLabel();
        Console.WriteLine();
        
        order4.ShippingCost(customer4.InUSA(address4.InUSAOrNot()));
        order4.TotalCost(o4costs);
        Console.WriteLine();
    }
}
        