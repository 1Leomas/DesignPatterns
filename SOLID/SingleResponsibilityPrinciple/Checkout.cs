namespace SingleResponsibilityPrinciple;

internal class Checkout
{
    public float GetShoppingCardPrice(ShoppingCart shoppingCart)
    {
        return shoppingCart.Items.Sum(x => x.Price);
    }
}