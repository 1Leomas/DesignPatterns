using Strategy.Context;
using Strategy.Strategies;

Player player = new("Bob");

player.Attack();

player.SetWeapon(new LaserGun());

player.Attack();

player.SetWeapon(new ShootGun());

player.Attack();

Console.ReadLine();
