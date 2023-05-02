using Decorator;

IWeight barbell = new Barbell();
Console.WriteLine($"Initial weight of barbell: {barbell.GetWeight()}");

Console.WriteLine("\nAdd 10kg weight to barbell");
barbell = new TenKgWeight(barbell);
Console.WriteLine("Add 10kg weight to barbell");
barbell = new TenKgWeight(barbell);

Console.WriteLine($"\nCurrent weight of barbell: {barbell.GetWeight()}");

Console.WriteLine("\nAdd 5kg weight to barbell");
barbell = new FiveKgWeight(barbell);
Console.WriteLine("Add 5kg weight to barbell");
barbell = new FiveKgWeight(barbell);

Console.WriteLine($"\nCurrent weight of barbell: {barbell.GetWeight()}");