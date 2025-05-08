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
		  double x = Convert.ToDouble(Console.ReadLine());
          Console.Write("\n2. Sayı: ");
		  double y = Convert.ToDouble(Console.ReadLine());
		  Calculator calc = new Calculator();
		  Console.WriteLine("Choose operation (+,-,*,/)");
          string operation = Console.ReadLine("");
          switch (operation)
          {
			 case "+":
                System.Console.WriteLine(calc.sum(x,y));
				  break;
            case "-":
                System.Console.WriteLine(calc.substract(x,y));
                break;
            case "*":
                System.Console.WriteLine(calc.multiply(x,y));
                break;
            case "/":
                System.Console.WriteLine(calc.divide(x,y));
                break;

            default:
                System.Console.WriteLine("Womp womp idk what u sayin");
          }
		}
	}
}