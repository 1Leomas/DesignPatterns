using Singleton;

var party = new Party();

party.Persons.Add(new Person("Ion"));
party.Persons.Add(new Person("Danu"));

Console.WriteLine("Persons at party:");
foreach (var p in party.Persons)
{
    Console.WriteLine("Name: {0}", p.Name);
}
Console.WriteLine();

party.Persons[0].MusicPlayer.MusicPlayerVolume();
party.Persons[0].MusicPlayer.IncreaseVolume();
party.Persons[0].MusicPlayer.MusicPlayerVolume();
Console.WriteLine();

party.Persons[1].MusicPlayer.DecreaseVolume();
party.Persons[1].MusicPlayer.DecreaseVolume();
party.Persons[1].MusicPlayer.MusicPlayerVolume();
