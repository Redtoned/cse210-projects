using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break;
            }

            numbers.Add(number);
        }

        // Core requirement 1: sum
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }

        // Core requirement 2: average
        double average = (double)sum / numbers.Count;

        // Core requirement 3: largest number
        int max = numbers[0];
        foreach (int n in numbers)
        {
            if (n > max)
            {
                max = n;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // Stretch challenge 1: smallest positive number
        int? smallestPositive = null;
        foreach (int n in numbers)
        {
            if (n > 0 && (smallestPositive == null || n < smallestPositive))
            {
                smallestPositive = n;
            }
        }

        if (smallestPositive != null)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }
        else
        {
            Console.WriteLine("There is no positive number in the list.");
        }

        // Stretch challenge 2: sort and display the list
        numbers.Sort();

        Console.WriteLine("The sorted list is:");
        foreach (int n in numbers)
        {
            Console.WriteLine(n);
        }
    }
}