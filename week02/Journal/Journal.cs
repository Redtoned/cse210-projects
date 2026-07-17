using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Callers add entries through this method rather than touching
    // _entries directly, so the internal storage type can change later
    // without breaking any code that calls AddEntry.
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.\n");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToFileString());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        List<Entry> loadedEntries = new List<Entry>();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            Entry entry = Entry.FromFileString(line);
            if (entry != null)
            {
                loadedEntries.Add(entry);
            }
        }

        // Loading replaces the current entries, as required.
        _entries = loadedEntries;
    }
}
