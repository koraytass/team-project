using System;

public class Flight
{
    public string Brand;
    public string where;

    public void Start()
    {
        Console.WriteLine($"{Brand} {where} kapilari kapanmak uzere.");
    }
}

public class Program
{
    public static void Main()
    {
        Flight myflight = new Flight();
        myflight.Brand = "SunExpress";
        myflight.where = "Barcelona";
        myflight.Start();
    }
}
