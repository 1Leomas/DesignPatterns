namespace InterfaceSegregationPrinciple;

internal class Circle: Shape
{
    private double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public override double Aria()
    {
        return Math.PI * _radius * _radius;
    }
}