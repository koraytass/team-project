
using System;

public class Phone
{
	public string Brand;
	public string Model;
	public int Storage;
		
	public void stockout()
	{
		Console.WriteLine($"{Brand} {Model} {Storage} is stockout.");
	}
	
}

public class Program	
{
	public static void Main()
	{
		Phone newPhone = new Phone();
		newPhone.Brand = "iphone";
		newPhone.Model = "iphone16";
      	newPhone.Storage = 500;
		newPhone.stockout();
	}
}