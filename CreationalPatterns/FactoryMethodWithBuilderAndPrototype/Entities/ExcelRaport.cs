using FactoryMethod.Abstract;

namespace FactoryMethod.Entities;

internal class ExcelRaport : IRaport
{
    public string? Name { get; set; }
    public string ContentType { get; set; }
    public string? Header { get; set; }
    public string? Body { get; set; }
    public string? Footer { get; set; }

    public ExcelRaport()
    {
        ContentType = "Excel";
    }

    public void Print()
    {
        if (!string.IsNullOrEmpty(Name))
            Console.WriteLine("Nume: {0}", Name);
        if (!string.IsNullOrEmpty(Header))
            Console.Write(Header);
        if (!string.IsNullOrEmpty(Body))
            Console.Write(Body);
        if (!string.IsNullOrEmpty(Footer))
            Console.WriteLine(Footer);
    }

    public IRaport Clone()
    {
        return new ExcelRaport()
        {
            Name = this.Name,
            ContentType = this.ContentType,
            Header = this.Header,
            Body = this.Body,
            Footer = this.Footer
        };
    }
}