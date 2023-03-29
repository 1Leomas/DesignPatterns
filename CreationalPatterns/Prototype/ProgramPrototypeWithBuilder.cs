using Builder;

var sandwichDirector = new SandwichFluentBuilderDirector();

var tastySandwich = sandwichDirector.BuildTastySandwich();

Console.WriteLine("Our tasty sandwich have: ");
Console.WriteLine(tastySandwich);

var newSandwich = tastySandwich.Clone();
newSandwich.Tomatoes = false;

Console.WriteLine("Our cloned sandwich have: ");
Console.WriteLine(newSandwich);