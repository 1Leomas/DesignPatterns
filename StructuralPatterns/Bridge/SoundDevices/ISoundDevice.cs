namespace Bridge.SoundDevices;

public interface ISoundDevice
{
    void IncreaseVolume();
    void DecreaseVolume();
    short ShowVolume();
    void SetVolume(short volume);   
}