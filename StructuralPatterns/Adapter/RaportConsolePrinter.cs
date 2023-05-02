using FactoryMethodWithBuilderAndPrototype.Entities;

namespace Adapter;

public class RaportConsolePrinter
{
    public void Print(Raport raport)
    {
        Console.WriteLine($"Name: {raport.Name}");
        Console.WriteLine($"Headers:");
        foreach (var i in raport.Headers)
        {
            Console.WriteLine($"\t{i}");
        }
        Console.WriteLine($"Body:");
        foreach (var row in raport.Body)
        {
            foreach (var cell in row)
            {
                Console.Write($"{cell} ");
            }
            Console.WriteLine();
        }
    }
}