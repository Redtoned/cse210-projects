using System;

namespace ScriptureMemorizer
{
    public class Word
    {
        private readonly string _text;
        private bool _isHidden;

        public Word(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentException("Word text cannot be empty.", nameof(text));
            }

            _text = text;
            _isHidden = false;
        }

        public bool IsHidden => _isHidden;

        public void Hide()
        {
            _isHidden = true;
        }

        public void Show()
        {
            _isHidden = false;
        }
        public string GetDisplayText()
        {
            if (!_isHidden)
            {
                return _text;
            }

            char[] hiddenChars = new char[_text.Length];
            for (int i = 0; i < _text.Length; i++)
            {
                hiddenChars[i] = char.IsLetter(_text[i]) ? '_' : _text[i];
            }

            return new string(hiddenChars);
        }
    }
}
