using System;
					
public class MakeupProduct
{
	public string Name;
	public string Brand;
	
	public void Describe()
	{
		Console.WriteLine($"The makeup product {Name} by {Brand} is teady to use.");
	}
}

public class Program
{
	public static void Main()
	{
		MakeupProduct lipstick = new MakeupProduct();
		lipstick.Name = "Velvet Matte Lipstick";
		lipstick.Brand = "MAC";
		lipstick.Describe();
		
		MakeupProduct foundation = new MakeupProduct();
		foundation.Name = "Skin Foundation";
		foundation.Brand = "Maybelline";
		foundation.Describe();
		
		MakeupProduct mascara = new MakeupProduct();
        mascara.Name = "Lash Sensational";
        mascara.Brand = "L'Oréal";
        mascara.Describe();
    }
}
		
		