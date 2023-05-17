using Observer.Context;
using Strategy.Strategies;

namespace Observer.Publisher;

internal class WeaponObserver: IObserver
{
    private readonly IWeapon _weapon;

    public WeaponObserver(IWeapon weapon)
    {
        _weapon = weapon;
    }

    public void Update(OnlinePlayer player)
    {
        if(player.GetWeapon()?.GetType().Name == _weapon.GetType().Name) 
            Console.WriteLine($"Observer: {player.Name} " +
                              $"used a {player.GetWeapon()?.GetType().Name}\n");
    }
}