using System;

// Temel sinif
public class TahminOyunu
{
	public int HedefSayi;
	public int MaxDeneme;
	
	public void Oyna()
	{
		Random rnd = new Random();
		HedefSayi = rnd.Next(1, 11); //1 ile 10 arasinda sayi 
		MaxDeneme = 3;
		
		Console.WriteLine("1 ile 10 arasinda bir sayi tuttum. Tahmin etmeye calis!");
		
		int oncekiFark = int.MaxValue;
		
		for (int i = 1; i <= MaxDeneme; i++)
		{
			Console.Write($"Deneme {i}: ");
			int tahmin = Convert.ToInt32(Console.ReadLine());
			
			if (tahmin == HedefSayi)
			{
				Console.WriteLine("Tebrikler! Bildin 🥳");
				return;
			}
			else
			{
				int simdikiFark = Math.Abs(HedefSayi - tahmin);
				
				if (simdikiFark < oncekiFark)
				{
					Console.WriteLine("Yaklasiyorsun! 👏🏻");
				}
				else
				{
					Console.WriteLine("Uzaklasiyorsun ☠️");
				}
				
				oncekiFark = simdikiFark;
			}
		}
		
		Console.WriteLine($"Uzgunum, bilemedin. Sayi {HedefSayi} idi.");
	}
}

// Kalitim yapan sinif 
public class GelismisTahminOyunu : TahminOyunu
{
  public void AralikVeDenemeBelirle(int maxSayi, int maxDeneme)
  {
      Random rnd = new Random();
	  HedefSayi = rnd.Next(1, maxSayi + 1);
	  MaxDeneme = maxDeneme;
	  
	  Console.WriteLine($"1 ile {maxSayi} arasinda bir sayi tuttum. Tahmin etmeye calis.");
	  
	  int oncekiFark = int.MaxValue;
	  
	  for (int i = 1; i <= MaxDeneme; i++)
	  {
	  Console.Write($"Deneme {i}: ");
	  int tahmin = Convert.ToInt32(Console.ReadLine());
	  
	  if (tahmin == HedefSayi)
	  {
	  Console.WriteLine("Harikaisin! Dogru bildin 👁👄👁");
	  return;
	  }
	  else
	  {
	    int simdikiFark = Math.Abs(HedefSayi - tahmin);
		
		if (simdikiFark < oncekiFark)
		{
		   Console.WriteLine("Yaklaşıyorsun 🔥");
         }
		 else 
		 {
		 Console.WriteLine("Uzaklaşıyorsun 🥶");
          }
		
		oncekiFark = simdikiFark;
		}
		{
		
		Console.WriteLine($"Oyun bitti! Dogru sayi: {HedefSayi}");
		}
     }
}
	 
	 public class Program
	 {
	 public static void Main()
	 {
	 // ilk oyun: temel oyun
	 TahminOyunu oyun = new TahminOyunu ();
	 oyun . Oyna();
	 
	 // Ikinci oyun: gelismis oyun
	 GelismisTahminOyunu gelismisOyun = new GelismisTahminOyunu();
	 gelismisOyun.AralikVeDenemeBelirle(20, 5);
	 }
}
}
		
	  