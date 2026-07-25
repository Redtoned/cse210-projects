using System;

namespace ScriptureMemorizer
{
    public class ScriptureReference
    {
        private readonly string _book;
        private readonly int _chapter;
        private readonly int _startVerse;
        private readonly int _endVerse;

        public ScriptureReference(string book, int chapter, int verse)
            : this(book, chapter, verse, verse)
        {
        }

        public ScriptureReference(string book, int chapter, int startVerse, int endVerse)
        {
            if (string.IsNullOrWhiteSpace(book))
            {
                throw new ArgumentException("Book name cannot be empty.", nameof(book));
            }
            if (chapter <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(chapter), "Chapter must be positive.");
            }
            if (startVerse <= 0 || endVerse <= 0)
            {
                throw new ArgumentOutOfRangeException("Verse numbers must be positive.");
            }
            if (endVerse < startVerse)
            {
                throw new ArgumentException("End verse cannot be before start verse.");
            }

            _book = book;
            _chapter = chapter;
            _startVerse = startVerse;
            _endVerse = endVerse;
        }
        public string GetDisplayText()
        {
            return _startVerse == _endVerse
                ? $"{_book} {_chapter}:{_startVerse}"
                : $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}
