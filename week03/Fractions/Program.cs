using System;

class Program
{
    static void Main(string[] args)
    {
        Fractions fraction1 = new Fractions();
        Fractions fraction2 = new Fractions("6");
        Console.WriteLine($"The fraction form for object fraction2 is: {fraction2.GetFractionString()}");
        Console.WriteLine($"The decimal form for object fraction2 is: {fraction2.GetDecimalValue()}");
        Fractions fraction3  = new Fractions("6","7");
        Console.WriteLine($"The fraction form for object fraction3 is: {fraction3.GetFractionString()}");
        Console.WriteLine($"The decimal form for object fraction3 is: {fraction3.GetDecimalValue()}");
        Fractions fraction4 = new Fractions();
        
        fraction2.SetNumerator("5");
        fraction3.SetNumerator("3");
        fraction3.SetDenominator("4");
        fraction4.SetNumerator("1");
        fraction4.SetDenominator("3");

        Console.WriteLine($"The fraction form for object fraction1 is: {fraction1.GetFractionString()}");
        Console.WriteLine($"The decimal form for object fraction1 is: {fraction1.GetDecimalValue()}");
        Console.WriteLine($"The fraction form for object fraction2 is: {fraction2.GetFractionString()}");
        Console.WriteLine($"The decimal form for object fraction2 is: {fraction2.GetDecimalValue()}");
        Console.WriteLine($"The fraction form for object fraction3 is: {fraction3.GetFractionString()}");
        Console.WriteLine($"The decimal form for object fraction3 is: {fraction3.GetDecimalValue()}");
        Console.WriteLine($"The fraction form for object fraction4 is: {fraction4.GetFractionString()}");
        Console.WriteLine($"The decimal form for object fraction4 is: {fraction4.GetDecimalValue()}");

    }
}