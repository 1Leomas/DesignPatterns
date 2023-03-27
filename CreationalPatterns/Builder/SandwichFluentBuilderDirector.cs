using Builder.Ingredients;

namespace Builder;

internal class SandwichFluentBuilderDirector
{
    private readonly SandwichFluentBuilder _sandwichFluentBuilder;

    public SandwichFluentBuilderDirector()
    {
        _sandwichFluentBuilder = new SandwichFluentBuilder();
    }

    public Sandwich BuildTastySandwich()
    {
        return _sandwichFluentBuilder
            .AddSausage(Sausage.FillettiCodru)
            .AddCheese(Cheese.Mozzarella)
            .AddMayonnaise()
            .AddCabbage()
            .AddTomatoes()
            .GetSandwich();
    }

    public Sandwich BuildVegetarianSandwich()
    {
        return _sandwichFluentBuilder
            .AddCheese(Cheese.Parmesan)
            .AddCabbage()
            .AddTomatoes()
            .GetSandwich();
    }
}