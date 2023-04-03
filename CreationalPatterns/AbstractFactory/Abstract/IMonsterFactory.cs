namespace AbstractFactory.Abstract;

internal interface IMonsterFactory
{
    IGoblin CreateGoblin(int dps, int hp);
    IElf CreateElf(int dps, int hp);
}