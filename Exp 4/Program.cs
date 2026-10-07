using System;

public delegate void ProductDetails();

class Shopping
{
    public static void Product1()
    {
        Console.WriteLine("Product : Laptop");
        Console.WriteLine("Price : Rs.50000");
        Console.WriteLine("Quantity : 1");
        Console.WriteLine("Brand : HP");
    }

    public static void Product2()
    {
        Console.WriteLine("Product : Headphones");
        Console.WriteLine("Price : Rs.2500");
        Console.WriteLine("Quantity : 1");
        Console.WriteLine("Brand : Boat");
    }

    static void Main(string[] args)
    {
        ProductDetails pd = Product1;

        Console.WriteLine("Product 1 Details");
        pd();

        Console.WriteLine("-------------------------");

        pd = Product2;
        
        Console.WriteLine("Product 2 Details");
        pd();

        Console.ReadLine();
    }
}