namespace Proxy;

public interface ICook
{
    IDictionary<int, string> GetStatuses();
    IEnumerable<Order> GetOrders();
}