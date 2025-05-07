using System;
					
public class Bikes
{
	public string brand;
	public int model;
	
	public void Ilanlar()
	{
		Console.WriteLine($"{brand} marka ve {model} model olan motoru satalim.");
	}
}
public class Motor()
{
	public static void Main()
	{ 
		Bikes bikes = new Bikes();
        bikes.brand = "Yamaha";
        bikes.model = 09;
        bikes.Ilanlar();
	}
}