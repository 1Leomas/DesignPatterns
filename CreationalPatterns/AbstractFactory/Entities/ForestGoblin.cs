using AbstractFactory.Abstract;
using System.Text;

namespace AbstractFactory.Entities;

internal class ForestGoblin : IGoblin
{
    private int _dps;
    private int _hp;
    private string _skinColor;

    public ForestGoblin(int dps, int hp)
    {
        _dps = dps;
        _hp = hp;
        _skinColor = "Green";
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