namespace Command.Commands;

internal interface ICommand
{
    void Execute();
    void Undo();
}