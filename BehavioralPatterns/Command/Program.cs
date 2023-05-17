using Command.Sender;

var editor = new Editor();

while (true)
{
    Console.Clear();
    Console.WriteLine($"Current list: {editor.GetText()}");

    Console.WriteLine("\nOptions: 1 - add, 2 - delete, 3 - undo, 4 - exit");
    Console.Write("Select: ");
    var input = Console.ReadKey().Key;
    Console.WriteLine("\n");

    switch (input)
    {
        case ConsoleKey.D1:
            Console.Write("Enter text to add: ");
            var textToAdd = Console.ReadLine();

            if (string.IsNullOrEmpty(textToAdd)) 
                continue;
            editor.AddText(textToAdd);
            break;
        case ConsoleKey.D2:
            Console.Write("Enter position: ");
            var position = int.Parse(Console.ReadLine() ?? "99");
            editor.DeleteText(position);
            break;
        case ConsoleKey.D3:
            editor.Undo();
            break;
        case ConsoleKey.D4:
            return;
        default:
            Console.WriteLine("Invalid command.");
            Thread.Sleep(1000);
            break;
    }
}