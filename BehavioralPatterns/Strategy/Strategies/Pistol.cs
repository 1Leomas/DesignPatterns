namespace Strategy.Strategies;

public class Pistol : IWeapon
{
    public void Shoot()
    {
        Console.WriteLine("shoots with a pistol");
    }
}