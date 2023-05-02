namespace Decorator;

public class FiveKgWeight: WeightDecorator
{
    public FiveKgWeight(IWeight weight) : base(weight) { }

    public override int GetWeight()
    {
        return _weight.GetWeight() + 5;
    }
}