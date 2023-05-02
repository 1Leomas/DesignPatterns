namespace Proxy;

public static class DataBase
{ 
    public static IDictionary<int, string> GetStatuses()
    {
        Dictionary<int, string> statuses = new()
        {
            { 1, "ready" },
            { 2, "not ready" },
            { 3, "preparing" }
        };

        //simulation a latency to the database
        Thread.Sleep(4000);

        return statuses;
    }
}