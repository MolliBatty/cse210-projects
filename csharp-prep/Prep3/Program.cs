using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicnumberInt = randomGenerator.Next(1,101);

        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();

       int guessInt = int.Parse(guess);

        while (guessInt != magicnumberInt)
        {
            if (guessInt > magicnumberInt)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Higher");
            }
    
            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            guessInt = int.Parse(guess);
        }
        Console.WriteLine("You guessed it!");
    }
}