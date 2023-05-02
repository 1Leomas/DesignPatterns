namespace Decorator;

public class TenKgWeight: WeightDecorator
{
    public TenKgWeight(IWeight weight) : base(weight) { }

    public override int GetWeight()
    {
        return _weight.GetWeight() + 10;
    }
}