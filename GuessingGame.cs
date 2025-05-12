using System;


public class GuessingGame
{
    public int maxTries = 3;
    public int maxRange = 9;
    public void Play()
    {
        Random rn = new Random();
        int answer = rn.Next(0,maxRange+1);
        int? prevDiff = null;
        for (int i = 0; i < maxTries + 1; i++)
        {
            if (i == maxTries)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Womp womp u couldnt guess it");
                Console.BackgroundColor = ConsoleColor.Black;
                break;
            }
            Console.WriteLine($"You have {maxTries - i} tries left.");
            Console.Write("Pick a number between 0-"+maxRange+" : ");
            int guess = Convert.ToInt32(Console.ReadLine());
            if (guess == answer)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("🥳🥳🥳 Woahh you guessed it.");
                Console.BackgroundColor = ConsoleColor.Black;
                break;
            }

            int currDiff = Math.Abs(answer - guess);

            if (prevDiff.HasValue)
            {
                if (currDiff < prevDiff)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("🔥 Getting hotter!");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else if (currDiff > prevDiff)
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("🥶 Getting colder!");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("😐 Neither hotter or colder.");
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            }

            prevDiff = currDiff;
        }


    }
}

public class Program
{
    public static void Main()
    {
        GuessingGame game = new GuessingGame();
        game.maxRange = 9;
        game.maxTries = 3;
        game.Play();

    }
}