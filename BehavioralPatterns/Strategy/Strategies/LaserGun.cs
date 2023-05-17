namespace Strategy.Strategies;

public class LaserGun : IWeapon
{
    public void Shoot()
    {
        Console.WriteLine("shoots with a laser gun");
    }
}