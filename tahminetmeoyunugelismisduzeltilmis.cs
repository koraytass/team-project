using System;

public class TahminOyunu
{
    public int Sayi;
    public int Maxdeneme;

    public void TahminOyunuOyna()
    {
        // ... existing code ...
    }
} 

public class GelismisTahminOyunu : TahminOyunu
{
    public void AralikVeDenemeBelirleme(int maxSayi, int maxDeneme)
    {
        Random rnd = new Random();
        Sayi = rnd.Next(1, maxSayi + 1);
        this.Maxdeneme = maxDeneme;

        Console.WriteLine("1 ile " + maxSayi + " arasında bir sayı tuttum. Tahmin etmeye çalışın!");
        Console.WriteLine("Toplam " + maxDeneme + " deneme hakkınız var.");

        int oncekifark = int.MaxValue;
        int kalanDeneme = maxDeneme; // Yeni değişken ekledik

        for (int i = 1; i <= kalanDeneme; i++)
        {
            Console.Write("tahmininizi giriniz:");
            int tahmin = Convert.ToInt32(Console.ReadLine());

            if (tahmin == Sayi)
            {
                Console.WriteLine("tebrikler! " + i + ". denemede bildiniz.");
                return;
            }
            else
            {
                int simdikifark = Math.Abs(Sayi - tahmin);

                if (simdikifark < oncekifark)
                {
                    Console.WriteLine("daha yakınsın.");
                }
                else
                {
                    Console.WriteLine("daha uzaksın.");
                }
                oncekifark = simdikifark;
            }
        }
        Console.WriteLine("maalesef bilemedin sayı " + Sayi + " idi.");
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("İlk oyun başlıyor...");
        TahminOyunu oyun = new TahminOyunu();
        oyun.TahminOyunuOyna();
        
        Console.WriteLine("\nİkinci oyun başlıyor...");
        GelismisTahminOyunu gelismisOyun = new GelismisTahminOyunu();
        gelismisOyun.AralikVeDenemeBelirleme(20, 5);
    }
}