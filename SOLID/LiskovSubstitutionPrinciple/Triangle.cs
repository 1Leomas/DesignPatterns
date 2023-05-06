namespace InterfaceSegregationPrinciple;

internal class Triangle: Shape
{
    private double _base;
    private double _height;

    public Triangle(double b, double height)
    {
        _base = b;
        _height = height;
    }

    public override double Aria()
    {
        return (_base * _height) / 2;
    }
}