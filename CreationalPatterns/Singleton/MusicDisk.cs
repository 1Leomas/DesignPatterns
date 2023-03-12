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

    public void ChangeCurrentPlay(int index)
    {
        if (index < 0 || index > _playList.Count)
        {
            Console.WriteLine("Bad input");
            return;
        }

        _currentPlay = _playList[index];
    }

}