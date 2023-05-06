using SingleResponsibilityPrinciple.Abstract;

namespace SingleResponsibilityPrinciple; 

internal class Checkout: ICheckoutService
{
    public float GetShoppingCartPrice(IShoppingCart shoppingCart)
    {
        return shoppingCart.GetItems().Sum(x => x.GetPrice());
    }
}