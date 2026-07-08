using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.WriteLine("What is your grade percentage?");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        if (grade >= 90)
        {
            Console.WriteLine("You received an A.");
        }

        else if (grade >= 80)
        {
            Console.WriteLine("You received a B.");
        }

        else if (grade >= 70)
        {
            Console.WriteLine("You received a C.");
        }

        else if (grade >= 60)
        {
            Console.WriteLine("You received a D.");
        }

        else
        {
            Console.WriteLine("You received an F.");
        }
    }
}