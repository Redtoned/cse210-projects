using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string input;
        int magicNumber;
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        do
        {
            Console.WriteLine("What is the magic number?");
            input = Console.ReadLine();
            magicNumber = int.Parse(input);

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

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("You made " + i + " guesses.");
        }
    }
}