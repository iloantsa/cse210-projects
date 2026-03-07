using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)

    {

        Random randomGenerator = new Random();
        int magicNumber= randomGenerator.Next(1, 101);
        int guess = -1;
        int guessCount = 0;
        while (magicNumber != guess)
        {

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            guessCount = guessCount + 1;




            if (magicNumber > guess)
            {
                Console.WriteLine($"Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine($"Lower");

            }
            else
            {
                Console.WriteLine($"You guessed it!");
            }
        }
        Console.WriteLine($"It took you {guessCount} guesses");




    }
}