using Bridge.Controllers;
using Bridge.SoundDevices;

var partyMusicPlayer = new PartyMusicPlayer();
var partySpeaker = new PartySpeaker();


var phoneController = new PhoneController();
phoneController.SoundDevice = partyMusicPlayer;

var remoteController = new RemoteController();
remoteController.SoundDevice = partySpeaker;

Console.Write("MusicPlayer Volume: ");
Console.WriteLine(partyMusicPlayer.ShowVolume());

phoneController.Mute();

Console.Write("MusicPlayer Volume: ");
Console.WriteLine(partyMusicPlayer.ShowVolume());

