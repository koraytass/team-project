
using System;
					
public class Makeup
{
    public string[] Names;
    public string[] Types;
    public double[] Prices;
	
	 public Makeup(int size)

    {
        Names = new string[size];
        Types = new string[size];
        Prices = new double[size];
	 } 

		public void Introduce(int index)
    {
        Console.WriteLine("Makyaj Ürünü: " + Names[index]);
        Console.WriteLine("Türü: " + Types[index]);
        Console.WriteLine("Fiyatı: " + Prices[index] + " TL");
			
	   Makeup makeup = new Makeup(3);
        
        makeup.Names[0] = "Gloss";
        makeup.Types[0] = "Kiko";
        makeup.Prices[0] = 850;

        makeup.Names[1] = "Fondöten";
        makeup.Types[1] = "Yapılandırıcı";
        makeup.Prices[1] = 1200;

        makeup.Names[2] = "Allık";
        makeup.Types[2] = "Pudra";
        makeup.Prices[2] = 1365;

        // Ürünleri tanıtalım
        for (int i = 0; i < 3; i++)
        {
            makeup.Introduce(i);
            Console.WriteLine();
        }
    }
}
