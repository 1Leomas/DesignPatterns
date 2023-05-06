namespace SingleResponsibilityPrinciple.Abstract;

internal interface IShoppingCart
{
    public IReadOnlyCollection<IProduct> GetItems();
    public void AddProduct(IProduct product);
    public void RemoveProduct(IProduct product);
}