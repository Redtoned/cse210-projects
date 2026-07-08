using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string input;
        string playAgain;

        do
        {
            int magicNumber;
            int guessCount = 0;
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 101);

            do
            {
                Console.WriteLine("What is the magic number?");
                input = Console.ReadLine();
                magicNumber = int.Parse(input);
                guessCount++;

                if (magicNumber < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber > number)
                {
                    Console.WriteLine("Lower");
                }
            } while (magicNumber != number);

            Console.WriteLine("You guessed the magic number!");
            Console.WriteLine("You made " + guessCount + " guesses.");

            Console.WriteLine("Do you want to play again? (yes/no)");
            playAgain = Console.ReadLine();

        } while (playAgain == "yes");

        Console.WriteLine("Thanks for playing the game!");
    }
}