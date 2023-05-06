namespace InterfaceSegregationPrinciple;

internal class Square: Shape
{
    private double _length;

    public Square(double length)
    {
        _length = length;
    }

    public override double Aria()
    {
        return _length * _length;
    }
}