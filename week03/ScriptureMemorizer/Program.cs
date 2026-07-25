using System;
using System.IO;

namespace ScriptureMemorizer
{
    public static class Program
    {
        private const int InitialWordsPerRound = 2;
        private const int MaxWordsPerRound = 6;
        private const string LibraryFileName = "scriptures.txt";

        public static void Main()
        {
            var library = new ScriptureLibrary();
            string dataFilePath = Path.Combine(AppContext.BaseDirectory, LibraryFileName);

            try
            {
                library.LoadFromFile(dataFilePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Could not load scripture library from '{dataFilePath}': {ex.Message}");
                return;
            }

            Scripture scripture = library.GetRandomScripture();
            RunMemorizationLoop(scripture);
        }

        /// <summary>
        /// Repeatedly displays the scripture, prompts the user, and hides more
        /// words each time Enter is pressed, until the user quits or every
        /// word has been hidden.
        /// </summary>
        private static void RunMemorizationLoop(Scripture scripture)
        {
            int round = 0;

            while (true)
            {
                ClearConsoleSafely();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine();
                Console.WriteLine($"({scripture.VisibleWordCount} of {scripture.WordCount} words still visible)");
                Console.WriteLine();

                if (scripture.AllWordsHidden())
                {
                    Console.WriteLine("The entire scripture is now hidden. Great work memorizing it!");
                    break;
                }

                Console.Write("Press Enter to hide more words, or type 'quit' to end: ");
                string input = Console.ReadLine();

                if (string.Equals(input?.Trim(), "quit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                round++;
                int wordsPerRound = Math.Min(InitialWordsPerRound + round / 2, MaxWordsPerRound);
                scripture.HideRandomWords(wordsPerRound);
            }
        }

        /// <summary>
        /// Clears the console, silently doing nothing if the program is running
        /// without a real terminal (e.g. output redirected to a file), so the
        /// program never crashes just because Console.Clear() isn't supported.
        /// </summary>
        private static void ClearConsoleSafely()
        {
            try
            {
                Console.Clear();
            }
            catch (IOException)
            {
            }
        }
    }
}
