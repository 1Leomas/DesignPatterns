using InterfaceSegregationPrinciple.Abstract;

namespace InterfaceSegregationPrinciple.Entity;

internal class Magician: IMagician
{
    public void CastSpell()
    {
        Console.WriteLine("Magician cast a spell!");
    }
}