using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.WriteLine("What is your grade percentage?");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letterGrade;
        string modifier = "";

        if (grade >= 90)
        {
            letterGrade = "A";
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        int remainder = grade % 10;

        if (letterGrade != "F")
        {
            if (remainder >= 7)
            {
                modifier = "+";
            }
            else if (remainder <= 2)
            {
                modifier = "-";
            }
        }

        if (letterGrade == "A" && modifier == "+")
        {
            modifier = "";
        }

        Console.WriteLine($"You received a {letterGrade}{modifier}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
        else
        {
            Console.WriteLine("Sorry, you failed the class.");
        }
    }
}