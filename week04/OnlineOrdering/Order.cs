using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
public class Order
{
    private List<string> products = new List<string>();
    private string customer { get; set; }
    private double totalCost = 0;
    private double shippingCost;
    private double roundedNumber;
    public void AddProducts(string product)
    {
        products.Add(product);
    }
        public void ShippingLabel(string name, string fullAddress)
    {
        customer = name;
        Console.WriteLine($"{customer}\n{fullAddress}");
    }
    public void ShippingCost(bool variable)
    {
        if (variable)
        {
            shippingCost = 5.00;
        }
        else
        {
            shippingCost = 35.00;
        }
    }
    public void PackingLabel()
    {
        foreach (string product in products)
        {
            Console.WriteLine(product);
        }
    }
    public void TotalCost(List<double> costs)
    {

        foreach (double cost in costs)
        {
            totalCost = totalCost + cost;
        }
        totalCost = totalCost + shippingCost;
        totalCost.ToString("F");
        roundedNumber = Math.Round(totalCost, 2); 

        Console.WriteLine($"Total: {roundedNumber}");
    }
}