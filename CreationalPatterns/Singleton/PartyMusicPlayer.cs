namespace Singleton;

public sealed class PartyMusicPlayer
{
    private static PartyMusicPlayer _instance;
    private short _volume = 50;
    private readonly MusicDisk _musicDisk;

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

    public void MusicPlayerVolume()
    {
        Console.WriteLine("Music player volume: {0}", _volume);
    }

    public void CheckMusicPlayerStatus()
    {
        Console.WriteLine();
        Console.WriteLine("-------Music-player-state-------");
        _musicDisk.CurrentPlay();
        MusicPlayerVolume();
        Console.WriteLine("--------------------------------");
    }

    public void PlayNextSong()
    {
        _musicDisk.PlayNextSong();
    }
}