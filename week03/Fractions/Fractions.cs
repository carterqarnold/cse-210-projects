using System;

public class Fractions
{
    private int _top;
    private int _bottom;
    public Fractions()
    {
        _top = 1;
        _bottom = 1;
        Console.WriteLine($"{_top}/{_bottom}");
    }
    public Fractions(int numerator)
    {
        _top = numerator;
        _bottom = 1;
        Console.WriteLine($"{_top}/{_bottom}");
    }
    public Fractions(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
        Console.WriteLine($"{_top}/{_bottom}");
    }
    public int GetNumerator()
    {
        return _top;
    }
    public void SetNumerator(int numerator)
    {
        _top = numerator;
    }
    public int GetDenominator()
    {
        return _bottom;
    }
    public void SetDenominator(int denominator)
    {
        _bottom = denominator;
    }
    public void GetFractionString()
    {
        Console.WriteLine($"{_top}/{_bottom}");
    }
    public double GetDecimalValue()
    {
        return (double) _top / (double) _bottom;
    }
}