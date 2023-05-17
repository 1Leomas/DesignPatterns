using Memento.Memento;

namespace Memento.Originator;

internal class User
{
    public string Name { get; private set; }

    public User(string name)
    {
        Name = name;    
    }
    public void SetRandomName()
    {
        Name = NameGenerator.Generate(new Random().Next(3, 6));
    }
    public IMemento Save()
    {
        return new NameMemento(Name);
    }
    public void Restore(IMemento memento)
    {
        Name = memento.GetState();
    }
}