public class Circle : Shape
{
    private int _radius;
    double pi = Math.PI;

    public Circle(int radius) : base("")
    {
        _radius = radius;
    }

    public double GetRadius()
    {
        return _radius;
    }
    public override double GetArea()
    {
        return (pi *Math.Pow(_radius, 2));
    }
}