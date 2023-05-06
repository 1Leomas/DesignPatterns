using InterfaceSegregationPrinciple.Abstract;
using InterfaceSegregationPrinciple.Entity;

IWarrior warrior = new Warrior();
IMagician magician = new Magician();
IWarlock warlock = new Warlock();

warrior.Attack();
warrior.Block();
Console.WriteLine();

magician.CastSpell();
Console.WriteLine();

warlock.CastSpell();
warlock.Attack();
warlock.Block();
warlock.Firestorm();
