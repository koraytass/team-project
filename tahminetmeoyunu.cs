using System;

public class TahminOyunu
{
public int Sayi;
public int Maxdeneme;

public void TahminOyunuOyna()
{
    Random rnd = new Random();
    Sayi = rnd.Next(1, 11);
    Maxdeneme = 3;
    Console.WriteLine("1 ile 11 arasında bir sayı tuttum. Tahmin etmeye çalışın!");

int oncekifark = int.MaxValue;

for (int i = 1; i <= Maxdeneme; i++)
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
            Console.WriteLine("daha yakınsınız!");
        }
        else
        {
            Console.WriteLine("daha uzaksınız!");
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
        TahminOyunu oyun = new TahminOyunu();
        oyun.TahminOyunuOyna();
    }
}