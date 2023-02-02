using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction _fraction = new Fraction();
        System.Console.WriteLine(_fraction.GetFractionString());
        System.Console.WriteLine(_fraction.GetDecimalValue());

        Fraction _fraction2 = new Fraction(5);
        System.Console.WriteLine(_fraction2.GetFractionString());
        System.Console.WriteLine(_fraction2.GetDecimalValue());

        Fraction _fraction3 = new Fraction(3, 4);
        System.Console.WriteLine(_fraction3.GetFractionString());
        System.Console.WriteLine(_fraction3.GetDecimalValue());

        int _topNum = _fraction.GetTop();
        int _bottomNum = _fraction.GetBottom();
        Fraction _userFraction = new Fraction(_topNum, _bottomNum);
        System.Console.WriteLine(_userFraction.GetFractionString());
        System.Console.WriteLine(_userFraction.GetDecimalValue());




    }
}