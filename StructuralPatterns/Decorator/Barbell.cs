namespace Decorator;

internal class Barbell: IWeight
{
    public int GetWeight()
    {
        return 10;
    }
}