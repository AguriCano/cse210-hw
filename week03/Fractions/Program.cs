using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        // Use getters y setters
        Console.WriteLine(fraction1.GetFractionString()); // 1/1
        Console.WriteLine(fraction1.GetDecimalValue());   // 1.0

        Console.WriteLine(fraction2.GetFractionString()); // 6/1
        Console.WriteLine(fraction2.GetDecimalValue());   // 6.0

        Console.WriteLine(fraction3.GetFractionString()); // 6/7
        Console.WriteLine(fraction3.GetDecimalValue());   // 0.857142857...

        fraction3.SetNumerator(3);
        fraction3.SetDenominator(4);
        Console.WriteLine(fraction3.GetFractionString()); // 3/4
        Console.WriteLine(fraction3.GetDecimalValue());   // 0.75
    }
}
public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    // Getters y Setters
    public int GetNumerator() { return _numerator; }
    public void SetNumerator(int numerator) { _numerator = numerator; }

    public int GetDenominator() { return _denominator; }
    public void SetDenominator(int denominator) { _denominator = denominator; }

    public string GetFractionString()
    {
        return _numerator + "/" + _denominator;
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}