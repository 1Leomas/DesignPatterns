using Observer.Context;

namespace Observer.Publisher;

internal interface IObserver
{
    void Update(OnlinePlayer player);
}       