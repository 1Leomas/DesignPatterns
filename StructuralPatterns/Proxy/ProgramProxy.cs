using Proxy;

//ICook cook = new Cook();

ICook cook = new CookProxy(new Cook());

while (true)
{
    Thread.Sleep(2000);

    Console.Clear();

    Console.WriteLine("========= Orders =========\n");

    var orders = cook.GetOrders();

    foreach (var order in orders)
    {
        string status = cook.GetStatuses().First(s => s.Key == order.StatusId).Value;

        Console.WriteLine($"{order.Name}\t\t{status}");
    }
}