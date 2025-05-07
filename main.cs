using System;

public class Human  
{
    public string Race;
    public string Weight;
    public int Age;

    public void Purchase()
    {
        Console.WriteLine($"You bought a/an ${Race}-${Age} human. Don't forget to feed them.");
    }
}

public class Program
{
    public static void Main()
    {
        Human myHuman = new Human();
        myHuman.Race = "White";
        myHuman.Weight = "110lbs";
        myHuman.Age = 21;

    }
}