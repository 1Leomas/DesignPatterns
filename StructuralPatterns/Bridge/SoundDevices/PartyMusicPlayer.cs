namespace Bridge.SoundDevices;

public sealed class PartyMusicPlayer : ISoundDevice
{
    private short _volume = 50;
    private readonly MusicDisk _musicDisk;

    public PartyMusicPlayer()
    {
        _musicDisk = new MusicDisk();
    }

    public void IncreaseVolume()
    {
        if (_volume is > 0 and < 100)
            _volume++;
    }

    public void DecreaseVolume()
    {
        if (_volume is > 0 and < 100)
            _volume--;
    }

    public short ShowVolume()
    {
        return _volume;
    }

    public void SetVolume(short volume)
    {
        _volume = volume switch
        {
            < 0 => 0,
            > 100 => 100,
            _ => volume
        };
    }

    public void CheckMusicPlayerStatus()
    {
        Console.WriteLine();
        Console.WriteLine("-------Music-player-state-------");
        _musicDisk.CurrentPlay();
        ShowVolume();
        Console.WriteLine("--------------------------------");
    }

    public void PlayNextSong()
    {
        _musicDisk.PlayNextSong();
    }
}