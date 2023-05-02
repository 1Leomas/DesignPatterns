using System.Text;

namespace SingleResponsibilityPrinciple;

internal class Product
{
    public string Name { get; set; } = string.Empty;
    public float Price { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new();
        sb.Append($"Name: {Name}");
        sb.AppendLine();
        sb.Append($"Price: {Price}");
        return sb.ToString();
    }
}