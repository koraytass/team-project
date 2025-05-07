using System;

public class Human  
{
    public string Race;
    public string Weight;
    public int Age;

    public void Purchase()
    {
        Console.WriteLine($"You already bought a/an ${Race}-${Age} human before.");
    }
}

void main(){
    Human myHuman = new Human();
    myHuman.Race = "Black";
    myHuman.Age = 24;
    myHuman.Weight = "110lbs";

    myHuman.Purchase();
    

}
