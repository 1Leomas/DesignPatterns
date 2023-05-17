using Memento.Caretaker;
using Memento.Originator;

var user = new User("Ion");
var caretaker = new Caretaker(user);

while (true)
{
    Console.Clear();
    Console.WriteLine($"User name: {user.Name}");
    Console.WriteLine($"Names saved: {caretaker.SavesCount()}");
    caretaker.Saves();

    Console.WriteLine("\nChange name(ENTER) Previous name(BACKSPACE)");
    var answer = Console.ReadKey().Key;
    if (answer == ConsoleKey.Enter)
    {
        caretaker.Save();
        user.SetRandomName();
    }
    else if (answer == ConsoleKey.Backspace)
        caretaker.Undo();
    else break;
}

Console.WriteLine($"\nYour final name will be: {user.Name}");