using Observer.Publisher;

namespace Observer.Context;

internal interface ISubject
{
    void Register(IObserver observer);
    void UnRegister(IObserver observer);

    void Notify();
}