using Observer.Context;
using Observer.Publisher;
using Strategy.Strategies;

var player1 = new OnlinePlayer("John");

player1.Register(new WeaponObserver(new Pistol()));

player1.SetWeapon(new ShootGun());
player1.Attack();

player1.SetWeapon(new Pistol());
player1.Attack();