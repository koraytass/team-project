using System;
					
public class Calculator                           
{
    public double Add(double a, double b)
	{
		return a + b; 
	}
	
	public double Subtract(double a, double b)
	{
		return a - b;
	}
	
	public double Multiply(double a, double b)
	{
		return a * b;
	}
    public double Divider(double a, double b)
	{
		if (b == 0)
		{
			 Console.WriteLine("Bölme işleminde payda 0 olamaz.");
				return 0;
		}
		return a / b;
	}
}

public class Program
{
	public static void Main()
	{
	Calculator hesap = new Calculator();
	 Console.WriteLine("ilk sayıyı girin.");
		double num1 = Convert. ToDouble(Console.ReadLine());
		 Console.WriteLine("ikinci sayıyı girin.");
		double num2 = Convert. ToDouble(Console.ReadLine());
		 Console.WriteLine("işlem seçin.");
		string islem = Console.ReadLine();

		double result = 0;
		
		switch (islem)
		{ 
			case "+":
				result = hesap.Add(num1, num2);
				break;
			case  "-":
				result = hesap.Subtract(num1, num2); 
				break;
			case"*":
				result = hesap.Multiply(num1, num2); 
				break;
			case"/":
				result = hesap.Divider(num1, num2); 
				break;
			default:
				Console.WriteLine("Invalid operation.");
				return;
				
		
	}
	Console.WriteLine($"Result: {result}");
}
}