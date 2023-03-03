public class Square : Shape
{
    private double _side;
    public Square(double side) : base("Black")
    {
        _side = side;
    }
    public double Get_side() 
    {
        return _side;
    }

    public override double GetArea()
    {

        return _side * _side;
    }
}