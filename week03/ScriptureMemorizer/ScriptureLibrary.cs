using System;
using System.Collections.Generic;
using System.IO;

namespace ScriptureMemorizer
{
    public class ScriptureLibrary
    {
        private readonly List<Scripture> _scriptures = new List<Scripture>();
        private static readonly Random _random = new Random();

        public int Count => _scriptures.Count;

        public void LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"Scripture file not found: {filePath}");
            }

            foreach (string rawLine in File.ReadAllLines(filePath))
            {
                string line = rawLine.Trim();
                if (line.Length == 0 || line.StartsWith("#"))
                {
                    continue;
                }

                string[] parts = line.Split('|');
                if (parts.Length != 5)
                {
                    continue;
                }

                string book = parts[0].Trim();
                int chapter = int.Parse(parts[1].Trim());
                int startVerse = int.Parse(parts[2].Trim());
                int endVerse = int.Parse(parts[3].Trim());
                string text = parts[4].Trim();

                var reference = new ScriptureReference(book, chapter, startVerse, endVerse);
                _scriptures.Add(new Scripture(reference, text));
            }
        }
        public Scripture GetRandomScripture()
        {
            if (_scriptures.Count == 0)
            {
                throw new InvalidOperationException("No scriptures loaded.");
            }

            return _scriptures[_random.Next(_scriptures.Count)];
        }
    }
}
