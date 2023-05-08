using Mediator.Mediator;

namespace Mediator.Components;

internal abstract class User
{
    public string Name { get; }

    private ICollegeChat? _chat;

    protected User(string name)
    {
        Name = name;
    }   

    public void SetChat(ICollegeChat? officeChat)
    {
        _chat = officeChat;
    }

    public void Send(string message)
    {
        _chat?.Send(Name, message);
    }

    public void SendTo<T>(string message) where T : User
    {
        _chat?.SendTo<T>(Name, message);
    }

    public virtual void Receive(string from, string message)
    {
        ColorWrite($"{Name,10}", ConsoleColor.DarkCyan);
        Console.Write($" ({this.GetType().Name}) received from ");
        ColorWrite($"{from,10}", ConsoleColor.DarkGreen);
        Console.Write(" message ");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        ColorWrite($"{message,10}\n", ConsoleColor.DarkYellow);

        void ColorWrite(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}