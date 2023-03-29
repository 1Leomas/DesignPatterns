using Builder.Ingredients;

namespace Builder;

internal class SandwichFluentBuilder
{
    private Sandwich _sandwich = new();

    public SandwichFluentBuilder()
    {
        Reset();
    }

    public SandwichFluentBuilder AddSausage(Sausage sausage)
    {
        _sandwich.Sausage = sausage;
        return this;
    }
    public SandwichFluentBuilder AddCheese(Cheese cheese)
    {
        _sandwich.Cheese = cheese;
        return this;
    }
    public SandwichFluentBuilder AddCaviar(Caviar caviar)
    {
        _sandwich.Caviar = caviar;
        return this;
    }
    public SandwichFluentBuilder AddTomatoes()
    {
        _sandwich.Tomatoes = true;
        return this;
    }
    public SandwichFluentBuilder AddButter()
    {
        _sandwich.Butter = true;
        return this;
    }
    public SandwichFluentBuilder AddCabbage()
    {
        _sandwich.Cabbage = true;
        return this;
    }
    public SandwichFluentBuilder AddMayonnaise()
    {
        _sandwich.Mayonnaise = true;
        return this;
    }

    public SandwichFluentBuilder AddKetchup()
    {
        _sandwich.Ketchup = true;
        return this;
    }


    public Sandwich GetSandwich()
    {
        var sandwich = _sandwich;
        Reset();
        return sandwich;
    }

    public void Reset()
    {
        _sandwich = new Sandwich();
    }
}