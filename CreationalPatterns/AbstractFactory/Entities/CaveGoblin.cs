using AbstractFactory.Abstract;
using System.Text;

namespace AbstractFactory.Entities;

internal class CaveGoblin : IGoblin
{
    private int _dps;
    private int _hp;
    private string _skinColor;

    public CaveGoblin(int dps, int hp)
    {
        _dps = dps * 2;
        _hp = hp * 2;
        _skinColor = "Grey";
    }

    public int GetDPS()
    {
        return _dps;
    }

    public int GetHP()
    {
        return _hp;
    }

    public string GetSkinColor()
    {
        return _skinColor;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.Append($"-{GetType().Name}-\n");
        sb.Append($"\tHP: {GetHP()}\n");
        sb.Append($"\tDPS: {GetDPS()}\n");
        sb.Append($"\tSkinColor: {GetSkinColor()}");
        return sb.ToString();
    }
}