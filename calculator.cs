using System;
using Internal;

public class Calculator
{
public double add(double num1, double num2)
{
    return num1 + num2;
}

public double sub(double num1, double num2)
{
    return num1 - num2;
}

public double mul(double num1, double num2)
{
    return num1 * num2;
}

public double div(double num1, double num2)
{
    if (num2 == 0)
    {
        Console.WriteLine("sayi sifira bolunemez");
        return 0;
    }
    else
    {
        return num1 / num2;
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("sayi giriniz:");
        double num1 = Convert.ToDouble(Console.readline());
    }s
}

