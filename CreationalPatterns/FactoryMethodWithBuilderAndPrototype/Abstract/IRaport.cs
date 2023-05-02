namespace FactoryMethodWithBuilderAndPrototype.Abstract;

public interface IRaport
{
    public string? Name { get; set; }
    public string ContentType { get; }
    public string? Header { get; set; }
    public string? Body { get; set; }
    public string? Footer { get; set; }
    void Print();
    IRaport Clone();
}