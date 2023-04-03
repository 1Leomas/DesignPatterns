using PrototypeWithBuilder;

var sandwichDirector = new SandwichFluentBuilderDirector();

var tastySandwich = sandwichDirector.BuildTastySandwich();
var newSandwich = tastySandwich.Clone();
newSandwich.Tomatoes = false;

Console.WriteLine("Our tasty sandwich have: ");
Console.WriteLine(tastySandwich);

Console.WriteLine("Our cloned sandwich have: ");
Console.WriteLine(newSandwich);