using System;
					
public class Kopekfonksiyonu
{
		public string Kopek;
		public string Cinsiyet;
		public int Yas;
	
	public void Ilan()
	{
		Console.WriteLine($"{Kopek} ve {Cinsiyet} ayrica {Yas} yasinda kopegi sahiplendrielim.");
	}
}   //test
public class Program
{
	public static void Main()
	{
		Kopekfonksiyonu myKopek = new Kopekfonksiyonu();
        myKopek.Cinsiyet = "Golden Retriever";
		myKopek.Yas = 2;
     	myKopek.Ilan();
	}
}
