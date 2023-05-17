using Strategy.Strategies;

namespace Strategy.Context;

public abstract class AbstractPlayer
{
    public string Name { get; }
    protected IWeapon? _weapon;
        
    protected AbstractPlayer(string name)
    {
        Name = name;
    }

    public virtual void SetWeapon(IWeapon weapon)
    {
        _weapon = weapon;
        Console.WriteLine("{0} pick a {1}\n", Name, weapon.GetType().Name);
    }

    public virtual void Attack()
    {
        if (_weapon is null)
        {
            Console.WriteLine($"\n{Name} can't attack. Set a weapon.");
            return;
        }

        Console.Write($"{Name} ");
        _weapon.Shoot();
    }
}