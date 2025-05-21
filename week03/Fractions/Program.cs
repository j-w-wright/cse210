using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fraction fraction1 = new Fraction();
        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()}");
        Console.WriteLine($"Decimal value of Fraction 1: {fraction1.GetDecimalValue()}");

        Fraction fraction2 = new Fraction(3);
        Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()}");
        Console.WriteLine($"Decimal value of Fraction 2: {fraction2.GetDecimalValue()}");

        Fraction fraction3 = new Fraction(8, 23);
        Console.WriteLine($"Fraction 3: {fraction3.GetFractionString()}");
        Console.WriteLine($"Decimal value of Fraction 3: {fraction3.GetDecimalValue()}");
    }
}