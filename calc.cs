using System;

namespace HelloWorld
{
  
  public class Calculator
  {
    public double sum(double x, double y){
      return x+y;
    }
    public double substract(double x, double y)
    {
      return x-y;  
    }
    public double divide(double x, double y){
      if(x == 0 || y == 0) {
		Console.WriteLine("Cannot be divided 0");
        return 0;
      }
      return (x/y);
    }
    public double multiply(double x, double y){
      return x * y;
    }
  }
  
  
  
	public class Program
	{
		public static void Main(string[] args)
		{
            Console.Write("1. Sayı: ");
		  double sayi = Convert.ToDouble(Console.ReadLine());
          Console.Write("\n2. Sayı: ");
		  double sayi1 = Convert.ToDouble(Console.ReadLine());
		  Calculator calc = new Calculator();
		  Console.WriteLine(calc.sum(sayi1, sayi));
		  Console.WriteLine(calc.substract(sayi1, sayi));
		  Console.WriteLine(calc.divide(sayi1, sayi));
		  Console.WriteLine(calc.multiply(sayi1, sayi));
		}
	}
}