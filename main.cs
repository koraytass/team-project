using System;

public class Human  
{
    public string Race;
    public string Weight;
    public int Age;

    public void Purchase()
    {
        Console.WriteLine($"You bought a/an ${Race}-${Age} human. Don't forget to feed them.");
    }
}

void main(){
    Human myHuman = new Human();
    myHuman.Race = "White";
    myHuman.Age = 24;
    myHuman.Weight = "110lbs";

    myHuman.Purchase();

}