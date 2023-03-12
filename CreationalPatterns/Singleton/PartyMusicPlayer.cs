using Singleton;

namespace DesignPatterns;

public sealed class PartyMusicPlayer
{
    private static PartyMusicPlayer _instance = null!;
    private short _volume = 50;

    public short Volume
    {
        get => _volume;
    }

    private MusicDisk _musicDisk;

    private PartyMusicPlayer()
    {
        _musicDisk = new MusicDisk();
    }

    public static PartyMusicPlayer Instance
    {
        get
        {
            if (_instance is null)
            {
                return _instance = new PartyMusicPlayer();
            }

            return _instance;
        }
    }

    public void IncreaseVolume()
    {
        if (_volume > 0 && _volume < 100)
            _volume++;
    }

    public void DecreaseVolume()
    {
        if (_volume > 0 && _volume < 100)
            _volume--;
    }

    public void LogVolume()
    {
        Console.WriteLine("Volume: {0}", _volume);
    }

    public void MusicPlayerState()
    {
        Console.WriteLine();
        Console.WriteLine("-------");
        Console.WriteLine("Music player state:");
        _musicDisk.CurrentPlay();
        LogVolume();
        Console.WriteLine("-------");
    }

    public void ChangeSong()
    {
        _musicDisk.SongList();

        Console.WriteLine("Enter number of the song you want to play");
        Console.Write("Input: ");
        var index = int.Parse(Console.ReadLine());

        _musicDisk.ChangeCurrentPlay(index);


    }
}