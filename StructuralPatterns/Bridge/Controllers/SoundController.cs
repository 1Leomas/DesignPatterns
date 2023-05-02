using Bridge.SoundDevices;

namespace Bridge.Controllers;

public abstract class SoundController
{
    public ISoundDevice SoundDevice { get; set; }

    public void IncreaseVolume()
    {
        SoundDevice.IncreaseVolume();   
    }

    public void DecreaseVolume()
    {
        SoundDevice.DecreaseVolume();
    }
}