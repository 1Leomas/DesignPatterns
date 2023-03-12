namespace Singleton;

public class MusicDisk
{
    private List<string> _playList;

    public string _currentPlay;

    public MusicDisk()
    {
        _playList = new List<string>()
        {
            "Carla's Dreams - Inapoi",
            "Irina Rimes - Acasa",
            "Irina Rimes - N-avem timp"
        };

        _currentPlay = _playList.First();
    }


    public void SongList()
    {
        Console.WriteLine("Music list: ");
        for (var i = 0; i < _playList.Count; i++)
        {
            var item = _playList[i];
            Console.WriteLine("\t{0} {1}", i, item);
        }
        Console.WriteLine();
    }

    public void CurrentPlay()
    {
        Console.WriteLine("Current play: {0}", _currentPlay);
    }

    public void PlayNextSong()
    {
        var indexOfCurrentPlay = _playList.IndexOf(_currentPlay);
        var indexOfLast = _playList.Count - 1;

        var index = (indexOfCurrentPlay == indexOfLast)
            ? 0
            : indexOfCurrentPlay + 1;

        _currentPlay = _playList[index];
    }

}