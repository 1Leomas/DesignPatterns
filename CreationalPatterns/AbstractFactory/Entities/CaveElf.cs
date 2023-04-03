using System.Text;
using AbstractFactory.Abstract;

namespace AbstractFactory.Entities;

internal class CaveElf : IElf
{
    private int _dps;
    private int _hp;
    private string _clanName;

    public CaveElf(int dps, int hp)
    {
        _dps = dps * 3;
        _hp = hp * 3;
        _clanName = "CaveElves";
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