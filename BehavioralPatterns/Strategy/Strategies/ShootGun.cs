namespace Strategy.Strategies;

public class ShootGun : IWeapon
{
    public void Shoot()
    {
        Console.WriteLine("shoots with a shoot gun");
    }
}