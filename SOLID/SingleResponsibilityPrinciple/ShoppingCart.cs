namespace SingleResponsibilityPrinciple;

internal class ShoppingCart
{
    private List<Product> _items = new List<Product>();

    public IReadOnlyCollection<Product> Items => _items;

    public void AddProduct(Product product)
    {
        _items.Add(product);
    }

    public void RemoveProduct(Product product)
    {
        _items.Remove(product);
    }
}   