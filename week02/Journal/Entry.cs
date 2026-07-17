using System;

public class Entry
{
    private string _date;
    private string _prompt;
    private string _response;

    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
    }

    // Display this entry's information to the screen.
    // Because Entry owns this method, Journal never needs to know
    // the internal field names or how many pieces of data an Entry holds.
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }

    // Convert this entry into a single line suitable for saving to a file.
    // Using a separator unlikely to appear in normal journal text.
    public string ToFileString()
    {
        return $"{_date}~|~{_prompt}~|~{_response}";
    }

    // Create an Entry from a single line read from a file.
    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split(new string[] { "~|~" }, StringSplitOptions.None);

        if (parts.Length != 3)
        {
            return null;
        }

        return new Entry(parts[0], parts[1], parts[2]);
    }
}
