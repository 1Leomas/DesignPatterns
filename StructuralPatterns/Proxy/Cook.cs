namespace Proxy;

public class Cook : ICook
{
    public IDictionary<int, string> GetStatuses()
    {
        return DataBase.GetStatuses();
    }

    public IEnumerable<Order> GetOrders()
    {
        List<Order> orders = new()
        {
            new Order { Name = "Burger", StatusId = RandomizeStatus() },
            new Order { Name = "French Fries", StatusId = RandomizeStatus() },
            new Order { Name = "Wings", StatusId = RandomizeStatus() }
        };

        return orders;
    }

    private static int RandomizeStatus() => new Random().Next(1,4);
}