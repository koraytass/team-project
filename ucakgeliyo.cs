using System;

public class Plane
{
    public string Brand;
    public string Model;
    public int Year;

    public void Start()
    {
        Console.WriteLine($"{Brand} {Model} ready for taxi.");
    }
}

public class Program
{
    public static void Main()
    {
        Plane myPlane = new Plane();
        myPlane.Brand = "Boeing";
        myPlane.Model = "777";
        myPlane.Year = 2026;
        myPlane.Start();
    }
}