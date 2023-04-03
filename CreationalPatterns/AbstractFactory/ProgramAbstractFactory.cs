using AbstractFactory.Factories;

int hp = 100;
int dps = 10;

var forestMonsterFactory = new ForestMonsterFactory();
var forestGoblin = forestMonsterFactory.CreateGoblin(dps, hp);
var forestElf = forestMonsterFactory.CreateElf(dps, hp);

Console.WriteLine(forestGoblin);
Console.WriteLine(forestElf);

var caveMonsterFactory = new CaveMonsterFactory();
var caveGoblin = caveMonsterFactory.CreateGoblin(dps, hp);
var caveElf = caveMonsterFactory.CreateElf(dps, hp);

Console.WriteLine(caveGoblin);
Console.WriteLine(caveElf);