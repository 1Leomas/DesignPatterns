using Bridge.SoundDevices;

namespace Bridge.Controllers;

public class PhoneController : SoundController
{
    public void SetVolume(short volume)
    {
        SoundDevice.SetVolume(volume);
    }

    public void Mute()
    {
        SoundDevice.SetVolume(0);
    }
}