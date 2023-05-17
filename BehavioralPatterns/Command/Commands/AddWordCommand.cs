using System.Text;

namespace Command.Commands;

public class AddWordCommand : ICommand
{
    private string _wordToAdd;
    private List<string> _previousWordList;
    private List<string> _wordList;

    public AddWordCommand(List<string> wordList, string wordToAdd)
    {
        _previousWordList = new List<string>();
        _wordList = wordList;
        _wordToAdd = wordToAdd;
    }

    public void Execute()
    {
        _previousWordList = new List<string>(_wordList);
        _wordList.Add(_wordToAdd);
    }

    public void Undo()
    {
        _wordList = new List<string>(_previousWordList);
    }
}