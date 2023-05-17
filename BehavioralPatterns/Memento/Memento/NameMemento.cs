namespace Memento.Memento;

internal class NameMemento: IMemento
{
    private readonly string _name;

    public NameMemento(string name)
    {
        _name = name;
    }

    public string GetState()
    {
        return _name;
    }
}