using System;

public class Fraction
{

    private int _bottom;
    private int _top;
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
       
    }
    public Fraction(int wholeNumber){
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom){
        _bottom = bottom;
        _top = top;
    }

    public int GetTop(){
        System.Console.WriteLine("Enter numerator: ");
        string _write = Console.ReadLine();
        int _numerator = int.Parse(_write);

        return _numerator;
    }

    public int GetBottom(){
        System.Console.WriteLine("Enter denomerator: ");
        string _write = Console.ReadLine();
        int _numerator = int.Parse(_write);

        return _numerator;
    }

    public string GetFractionString() {
        return $"{_top} / {_bottom}";
    }

    public double GetDecimalValue() {
        return (double)_top / (double) _bottom;
    }
}