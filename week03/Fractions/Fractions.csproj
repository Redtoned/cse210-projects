using System;

namespace Fractions
{
    public class Fraction
    {
        private int _top;
        private int _bottom;

        // Constructor with no parameters - initializes to 1/1
        public Fraction()
        {
            _top = 1;
            _bottom = 1;
        }

        // Constructor with one parameter - initializes denominator to 1
        public Fraction(int wholeNumber)
        {
            _top = wholeNumber;
            _bottom = 1;
        }

        // Constructor with two parameters
        public Fraction(int top, int bottom)
        {
            _top = top;
            _bottom = bottom;
        }

        // Getter and Setter for top
        public int GetTop()
        {
            return _top;
        }

        public void SetTop(int top)
        {
            _top = top;
        }

        // Getter and Setter for bottom
        public int GetBottom()
        {
            return _bottom;
        }

        public void SetBottom(int bottom)
        {
            _bottom = bottom;
        }

        // Returns the fraction as a string, e.g. "3/4"
        public string GetFractionString()
        {
            return $"{_top}/{_bottom}";
        }

        // Returns the decimal value of the fraction
        public double GetDecimalValue()
        {
            return (double)_top / _bottom;
        }
    }
}