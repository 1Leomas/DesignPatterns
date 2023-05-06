using InterfaceSegregationPrinciple.Abstract;

namespace InterfaceSegregationPrinciple.Entity;

internal class Warrior: IWarrior
{
    public void Attack()
    {
        Console.WriteLine("Warrior attacks!");
    }

    public void Block()
    {
        Console.WriteLine("Warrior blocks!");
    }
}