using System;

public class Program
{
    public static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator generator = new PromptGenerator();
        bool keepGoing = true;

        while (keepGoing)
        {
            Console.WriteLine("Journal Menu");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry(theJournal, generator);
                    break;

                case "2":
                    theJournal.DisplayAll();
                    break;

                case "3":
                    Console.Write("What is the filename? ");
                    string saveFilename = Console.ReadLine();
                    theJournal.SaveToFile(saveFilename);
                    Console.WriteLine("Journal saved.\n");
                    break;

                case "4":
                    Console.Write("What is the filename? ");
                    string loadFilename = Console.ReadLine();
                    theJournal.LoadFromFile(loadFilename);
                    Console.WriteLine("Journal loaded.\n");
                    break;

                case "5":
                    keepGoing = false;
                    break;

                default:
                    Console.WriteLine("Not a valid option. Please try again.\n");
                    break;
            }
        }
    }

    private static void WriteNewEntry(Journal theJournal, PromptGenerator generator)
    {
        string prompt = generator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();

        Console.Write("How are you feeling today? ");
        string feeling = Console.ReadLine();

        string date = DateTime.Now.ToShortDateString();

        Entry newEntry = new Entry(date, prompt, response, feeling);
        theJournal.AddEntry(newEntry);

        Console.WriteLine();
    }
}
