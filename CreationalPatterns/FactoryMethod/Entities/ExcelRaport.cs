using FactoryMethod.Abstract;

namespace FactoryMethod.Entities;

internal class ExcelRaport : IRaport
{
    public string Name { get; set; }
    public string ContentType { get; }
    public string Header { get; set; }
    public string Body { get; set; }
    public string Footer { get; set; }

    public ExcelRaport()
    {
        ContentType = "Excel";
    }

    public void Print()
    {
        Console.WriteLine("Nume: {0}", Name);
        Console.WriteLine(Header);
        Console.WriteLine(Body);
        Console.Write(Footer);
    }
}