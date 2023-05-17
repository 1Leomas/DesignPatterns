using Memento.Memento;
using Memento.Originator;
using Console = System.Console;

namespace Memento.Caretaker;

internal class Caretaker
{
    private readonly List<IMemento> _mementos = new();

    private readonly User _originator;

    public Caretaker(User originator)
    {
        _originator = originator;
    }

    public void Save()
    {
        _mementos.Add(_originator.Save());
    }

    public void Undo()
    {
        if (_mementos.Count == 0) return;

        var memento = _mementos.Last();
        _originator.Restore(memento);

        _mementos.Remove(memento);
    }

    public int SavesCount() => _mementos.Count;

    public void Saves()
    {
        _mementos.ForEach(m => { Console.Write($"{m.GetState()} "); });
        Console.WriteLine();
    }
}