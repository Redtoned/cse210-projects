using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private readonly ScriptureReference _reference;
        private readonly List<Word> _words;
        private static readonly Random _random = new Random();

        public Scripture(ScriptureReference reference, string text)
        {
            _reference = reference ?? throw new ArgumentNullException(nameof(reference));

            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException("Scripture text cannot be empty.", nameof(text));
            }

            _words = text
                .Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(w => new Word(w))
                .ToList();
        }
        public int WordCount => _words.Count;
        public int VisibleWordCount => _words.Count(w => !w.IsHidden);

        public string GetDisplayText()
        {
            var builder = new StringBuilder();
            builder.AppendLine(_reference.GetDisplayText());
            builder.AppendLine();
            builder.Append(string.Join(" ", _words.Select(w => w.GetDisplayText())));
            return builder.ToString();
        }

        public bool AllWordsHidden()
        {
            return _words.All(w => w.IsHidden);
        }

        public void HideRandomWords(int numberOfWords)
        {
            List<Word> candidates = _words.Where(w => !w.IsHidden).ToList();
            if (candidates.Count == 0)
            {
                return;
            }

            int wordsToHide = Math.Min(numberOfWords, candidates.Count);
            for (int i = 0; i < wordsToHide; i++)
            {
                int index = _random.Next(candidates.Count);
                candidates[index].Hide();
                candidates.RemoveAt(index);
            }
        }
    }
}
