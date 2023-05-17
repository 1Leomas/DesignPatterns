using Observer.Publisher;
using Strategy.Context;
using Strategy.Strategies;

namespace Observer.Context;

internal class OnlinePlayer : AbstractPlayer, ISubject
{
    private readonly List<IObserver> _observers;
    public IWeapon? GetWeapon() => _weapon;

    public OnlinePlayer(string name) : base(name) 
        => _observers = new List<IObserver>();

    public override void Attack()
    {
        base.Attack();
        if (_weapon is not null) Notify();
    }

    public void Register(IObserver observer) 
        => _observers.Add(observer);

    public void UnRegister(IObserver observer) 
        => _observers.Remove(observer);

    public void Notify() 
        => _observers.ForEach(o => o.Update(this));
}