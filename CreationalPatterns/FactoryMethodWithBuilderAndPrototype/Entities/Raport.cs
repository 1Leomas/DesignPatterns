namespace FactoryMethodWithBuilderAndPrototype.Entities;

public class Raport
{
    public string? Name { get; set; }
    public List<string> Headers { get; set; }
    public List<List<string>> Body{ get; set; }
    public string Footer { get; set; }
}