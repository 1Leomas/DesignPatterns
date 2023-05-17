using Command.Commands;
using System.Text;

namespace Command.Sender;

internal class Editor
{
    private readonly List<string> _wordList = new();
    private readonly Stack<ICommand> _undoCommands = new();

    public void AddText(string textToAdd)
    {
        var command = new AddWordCommand(_wordList, textToAdd);
        _undoCommands.Push(command);
        command.Execute();
    }

    public void DeleteText(int position)    
    {
        var command = new DeleteWordCommand(_wordList, position);
        _undoCommands.Push(command);
        command.Execute();
    }

    public void Undo()
    {
        if (_undoCommands.Count == 0) return;
        var command = _undoCommands.Pop();
        command.Undo();
    }

    public string GetText()
    {
        var sb = new StringBuilder();

        foreach (var word in _wordList)
        {
            sb.Append($"{word} ");
        }
        return sb.ToString();
    }
}