using System;

public class Calculator
{
public double add(double num1, double num2)
{
    return num1 + num2;
}

public double sub(double num1, double num2)
{
    return num1 - num2;
}

public double mul(double num1, double num2)
{
    return num1 * num2;
}

public double div(double num1, double num2)
{
    if (num2 == 0)
    {
        Console.WriteLine("cannot divide by zero");
        return 0;
    }
        return num1 / num2;
}

public class Program
{
    public static void Main()
    {
        Calculator calc = new Calculator();

        Console.WriteLine("Enter first number:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("choose operation:");
        string operation = Console.ReadLine();

        double result = 0;

        switch (operation)
        {
            case "+":
            result = calc.add(num1, num2);
            break;

            case "-":
            result = calc.sub(num1, num2);
            break;

            case "*":
            result = calc.mul(num1, num2);
            break;

            case "/":
            result = calc.div(num1, num2);
            break;

            default:
            Console.WriteLine("invalid operation");
            break;
            }
            Console.WriteLine("result: " + result);
        
    }
}
}

