using System.Text;
using Builder.Ingredients;

namespace Builder;

internal class Sandwich
{
    public Sausage Sausage { get; set; }
    public Cheese Cheese { get; set; }
    public Caviar Caviar { get; set; }
    public bool Tomatoes { get; set; }
    public bool Butter { get; set; }
    public bool Cabbage { get; set; }
    public bool Mayonnaise { get; set; }
    public bool Ketchup { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();

        var format = "{0}\n";

        if (Sausage != Sausage.None)
            sb.AppendFormat(format, $"Sausage: {Sausage}");
        if (Cheese != Cheese.None)
            sb.AppendFormat(format, $"Cheese: {Cheese}");
        if (Caviar != Caviar.None)
            sb.AppendFormat(format, $"Caviar: {Caviar}");
        if (Tomatoes)
            sb.AppendFormat(format, $"With {nameof(Tomatoes)}");
        if (Butter)
            sb.AppendFormat(format, $"With {nameof(Butter)}");
        if (Cabbage)
            sb.AppendFormat(format, $"With {nameof(Cabbage)}");
        if (Mayonnaise)
            sb.AppendFormat(format, $"With {nameof(Mayonnaise)}");
        if (Ketchup)
            sb.AppendFormat(format, $"With {nameof(Ketchup)}");

        return sb.ToString();
    }
}