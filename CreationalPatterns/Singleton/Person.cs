namespace Singleton;

internal class Person
{
    public string Name { get; } = String.Empty;

    public PartyMusicPlayer MusicPlayer { get; }

    public Person(string name)
    {
        Name = name;

        MusicPlayer = PartyMusicPlayer.Instance;
    }
}