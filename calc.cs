using System;

namespace HelloWorld
{

  public class Calculator
  {
    public double sum(double x, double y)
    {
      return x + y;
    }
    public double substract(double x, double y)
    {
      return x - y;
    }
    public double divide(double x, double y)
    {
      if (x == 0 || y == 0)
      {
        Console.WriteLine("Cannot be divided 0");
        return 0;
      }
      return (x / y);
    }
    public double multiply(double x, double y)
    {
      return x * y;
    }
  }



  public class Program
  {
    public static void Main(string[] args)
    {
      double sonuc = 0;
      string _operation;
      do
      {
        Console.Write("1. Sayı: ");

        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("\n2. Sayı: ");

        double y = Convert.ToDouble(Console.ReadLine());

        Calculator calc = new Calculator();

        Console.WriteLine("Choose operation (+,-,*,/)");
        
        string operation = Console.ReadLine();

        _operation = operation;
        
        switch (operation)
        {
          case "+":
            sonuc = calc.sum(x, y);
            break;
          case "-":
            sonuc = calc.substract(x, y);
            break;
          case "*":
            sonuc = calc.multiply(x, y);
            break;
          case "/":
            sonuc = calc.divide(x, y);
            break;

          default:
            System.Console.WriteLine("Womp womp idk what u sayin");
            break;
        }
        System.Console.WriteLine($"Sonuç : {sonuc}");
      } while (_operation == "-" && sonuc != 0);
      System.Console.WriteLine("Ended cuz the result is 0.");
    }
  }
}