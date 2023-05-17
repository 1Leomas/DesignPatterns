using System.Text;

namespace Command.Commands;

public class DeleteWordCommand : ICommand
{
    private readonly int _position;
    private List<string> _previousWordList;
    private List<string> _wordList;

    public DeleteWordCommand(List<string> wordList, int position)
    {
        _previousWordList = new List<string>();
        _wordList = wordList;
        _position = position;
    }

    public void Execute()
    {
        _previousWordList = new List<string>(_wordList);
        try
        {
            _wordList.RemoveAt(_position);
        }
        catch (Exception)
        {

        }
    }

    public void Undo()
    {
        _wordList = new List<string>(_previousWordList);
    }
}