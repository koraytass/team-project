using System;

public class truck
{
    public string Brand;
    public string Model;
    public int Year;
    public int size;

    public void Start()
    {
        Console.WriteLine($"{Brand} {Model} is starting.");
    }
} 