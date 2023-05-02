namespace Bridge.SoundDevices;

internal class PartySpeaker : ISoundDevice
{
    private short _volume = 50;

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
}