using System;

// Temel sınıf
public class TahminOyunu
{
    public int HedefSayi;
    public int MaxDeneme;

    public void Oyna()
    {
        Random rnd = new Random();
        HedefSayi = rnd.Next(1, 11);  // 1 ile 10 arasında sayı
        MaxDeneme = 3;

        Console.WriteLine("1 ile 10 arasında bir sayı tuttum. Tahmin etmeye çalış!");

        int oncekiFark = int.MaxValue;

        for (int i = 1; i <= MaxDeneme; i++)
        {
            Console.Write($"Deneme {i}: ");
            int tahmin = Convert.ToInt32(Console.ReadLine());

            if (tahmin == HedefSayi)
            {
                Console.WriteLine("Tebrikler! Bildin 🎉");
                return;
            }
            else
            {
                int simdikiFark = Math.Abs(HedefSayi - tahmin);

                if (simdikiFark < oncekiFark)
                {
                    Console.WriteLine("Yaklaşıyorsun! 🚀");
                }
                else
                {
                    Console.WriteLine("Uzaklaşıyorsun! ❄️");
                }

                oncekiFark = simdikiFark;
			}
		}
		
		Console.WriteLine($"Üzgünüm, bilemedin. Sayı {HedefSayi} idi.");
	}
}

//Kalitim yapan sınıf
public class GelismisTahminOyunu : TahminOyunu
{
 public void AralikVeDenemeBelirle(int maxSayi, int maxDeneme)
    {
	Random rnd = new Random();
	HedefSayi = rnd.Next(1, maxSayi + 1);
	MaxDeneme = maxDeneme;
	
	 Console.WriteLine($"1 ile {maxSayi} arasında bir sayı tuttum. Tahmin etmeye çalış!");

        int oncekiFark = int.MaxValue;

        for (int i = 1; i <= MaxDeneme; i++)
        {
            Console.Write($"Deneme {i}: ");
            int tahmin = Convert.ToInt32(Console.ReadLine());
			
			if (tahmin == HedefSayi)
			 {
                Console.WriteLine("Harikasın! Doğru bildin 🎯");
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
        }

        Console.WriteLine($"Oyun bitti! Doğru sayı: {HedefSayi}");
    }
}

public class Program
{
	public static void 	Main()
	{
		//ilk oyun: temel oyun
		GelismisTahminOyunu oyun = new GelismisTahminOyunu();
		oyun.Oyna();
		
	    // İkinci oyun: gelişmiş oyun
        GelismisTahminOyunu gelismisOyun = new GelismisTahminOyunu();
        gelismisOyun.AralikVeDenemeBelirle(20, 5);
    }
}
