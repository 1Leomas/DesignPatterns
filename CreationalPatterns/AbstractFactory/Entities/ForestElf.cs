using AbstractFactory.Abstract;
using System.Text;

namespace AbstractFactory.Entities;

internal class ForestElf : IElf
{
    private int _dps;
    private int _hp;
    private string _clanName;

    public ForestElf(int dps, int hp)
    {
        _dps = dps * 2;
        _hp = hp * 2;
        _clanName = "ForestElves";
    }

    public int GetDPS()
    {
        return _dps;
    }

    public int GetHP()
    {
        return _hp;
    }

    public string GetClanName()
    {
        return _clanName;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.Append($"-{GetType().Name}-\n");
        sb.Append($"\tHP: {GetHP()}\n");
        sb.Append($"\tDPS: {GetDPS()}\n");
        sb.Append($"\tClanName: {GetClanName()}");
        return sb.ToString();
    }
}