using InterfaceSegregationPrinciple.Abstract;

namespace InterfaceSegregationPrinciple.Entity;

internal class Warlock: IWarlock
{
    public void Attack()
    {
        Console.WriteLine("Warrior attacks with a invisible sword!");
    }

    public void Block()
    {
        Console.WriteLine("Warlock blocks!");
    }

    public void CastSpell()
    {
        Console.WriteLine("Warlock cast a simple spell!");
    }

    public void Firestorm()
    {
        Console.WriteLine("Warlock cast a firestorm!");
    }
}