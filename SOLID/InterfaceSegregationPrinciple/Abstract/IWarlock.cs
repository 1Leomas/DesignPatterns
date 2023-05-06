namespace InterfaceSegregationPrinciple.Abstract;

internal interface IWarlock: IWarrior, IMagician
{
    public void Firestorm();    
}