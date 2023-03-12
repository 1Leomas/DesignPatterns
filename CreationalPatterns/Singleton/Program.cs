using Singleton;

var party = new Party();

party.Persons.Add(new Person("Ion"));
party.Persons.Add(new Person("Danu"));

Console.WriteLine("Persons at the party:");
foreach (var p in party.Persons)
{
    Console.WriteLine("Name: {0}", p.Name);
}

party.Persons[0].MusicPlayer.CheckMusicPlayerStatus();

Console.WriteLine("\nIon changes volume");
party.Persons[0].MusicPlayer.IncreaseVolume();

party.Persons[0].MusicPlayer.CheckMusicPlayerStatus();

Console.WriteLine("\nDanu changes volume and song");
party.Persons[1].MusicPlayer.DecreaseVolume();
party.Persons[1].MusicPlayer.DecreaseVolume();
party.Persons[1].MusicPlayer.PlayNextSong();

party.Persons[0].MusicPlayer.CheckMusicPlayerStatus();
