using FactoryMethod.Abstract;

namespace FactoryMethod.Entities;

internal class XmlRaport : IRaport
{
    public string Name { get; set; }
    public string ContentType { get; set; }
    public List<string> Headers { get; set; }
    public List<string> Body { get; set; }
    public string Footer { get; set; }

    public void Print()
    {
        throw new NotImplementedException();
    }
}