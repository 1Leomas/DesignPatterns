namespace Proxy;

public class CookProxy : ICook
{
    private readonly Cook _cook;
    private IDictionary<int, string>? _statuses;

    public CookProxy(Cook cook)
    {
        _cook = cook;
    }

    public IEnumerable<Order> GetOrders()
    {
        Console.WriteLine
            ($"[{DateTime.Now:dd.MM.yyyy HH:mm:ss}] GetOrders()\n");

        return _cook.GetOrders();
    }

    public IDictionary<int, string> GetStatuses()
    {
        if( _statuses is null )
        {
            _statuses = DataBase.GetStatuses();
        }

        return _statuses;
    }
}