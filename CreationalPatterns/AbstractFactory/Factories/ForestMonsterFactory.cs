using AbstractFactory.Abstract;
using AbstractFactory.Entities;

namespace AbstractFactory.Factories;

internal class ForestMonsterFactory : IMonsterFactory
{
    public IGoblin CreateGoblin(int dps, int hp)
    {
        return new ForestGoblin(dps, hp);
    }

    public IElf CreateElf(int dps, int hp)
    {
        return new ForestElf(dps, hp);
    }
}