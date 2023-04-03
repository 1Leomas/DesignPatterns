using AbstractFactory.Abstract;
using AbstractFactory.Entities;

namespace AbstractFactory.Factories;

internal class CaveMonsterFactory : IMonsterFactory
{
    public IGoblin CreateGoblin(int dps, int hp)
    {
        return new CaveGoblin(dps, hp);
    }

    public IElf CreateElf(int dps, int hp)
    {
        return new CaveElf(dps, hp);
    }
}