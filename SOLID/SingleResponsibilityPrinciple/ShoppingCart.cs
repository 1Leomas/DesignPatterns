using SingleResponsibilityPrinciple.Abstract;

namespace SingleResponsibilityPrinciple;

internal class ShoppingCart: IShoppingCart
{       
    private readonly List<IProduct> _items = new();

    public IReadOnlyCollection<IProduct> GetItems()
    {
        return _items;
    }

    public void AddProduct(IProduct product)
    {
        _items.Add(product);
    }

    public void RemoveProduct(IProduct product)
    {
        _items.Remove(product);
    }
}   