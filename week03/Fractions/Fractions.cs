//Class Fractions
public class Fractions
{
    private string _numerator;
    private string _denominator;
    //Contructor with no parameters, default 1/1
    public Fractions()
    {
        _numerator = "1";
        _denominator = "1";
        
    }
    //Constructor with no denominator, example _numerator:5, it will create 5/1 
    public Fractions(string numerator)
    {
        _numerator = numerator;
        _denominator = "1";
        
    }
    //Constructor with numerator and denominator entered, example: numerator:5, denominator:4, will create 5/4
    public Fractions(string numerator, string denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
        
    }

    //Setters
    public void SetNumerator(string numerator)
    {
        _numerator = numerator;
    }
    public void SetDenominator(string denominator)
    {
        _denominator = denominator;
    }

    //Getters
    public string GetNumerator()
    {
        return _numerator;
    }

    public string GetDenominator()
    {
        return _denominator;
    }

    public string GetFractionString()
    {
        string _fractionString = GetNumerator() + "/" + GetDenominator();
        return _fractionString;
    }

    public double GetDecimalValue()
    {
        double _decimalValue = double.Parse(GetNumerator()) / double.Parse(GetDenominator());
        return _decimalValue;
    }
}