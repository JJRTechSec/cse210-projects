using System;

public class Fraction
{
    // ATTRIBUTES
    private int _top;
    private int _bottom;

    // CONSTRUCTORS
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // GETTERS AND SETTERS
    //public string GetTop()
    //public int SetTop(int top)
    //public void GetBottom()
    //public int SetBottom(int bottom)

    // METHODS
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double) _top / _bottom;
    }
}