using System;
					
public class Motor
{
	public string Model;
	public int CC;
	public int year;
	
	public void Start()
	{
	 Console.WriteLine($"{Model} marka, {CC} CC ve {year} yılı motor satın aldım");
	}
}

public class Program {
	public static void Main(){
		Motor myMotor = new Motor();
		myMotor.Model = "yamaha";
		myMotor.year = 23;
		myMotor.CC = 150;
		myMotor.Start();
	}
}
