namespace Decorator;

public abstract class WeightDecorator: IWeight
{
    protected IWeight _weight;

    public WeightDecorator(IWeight weight)
    {
        _weight = weight;
    }

    public abstract int GetWeight();
}
