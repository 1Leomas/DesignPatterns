using Builder;

var sandwichDirector = new SandwichFluentBuilderDirector();

var tastySandwich = sandwichDirector.BuildTastySandwich();

Console.WriteLine("Our tasty sandwich have: ");
Console.WriteLine(tastySandwich);

var vegetarianSandwich = sandwichDirector.BuildVegetarianSandwich();

Console.WriteLine("Our vegetarian sandwich have: ");
Console.WriteLine(vegetarianSandwich);