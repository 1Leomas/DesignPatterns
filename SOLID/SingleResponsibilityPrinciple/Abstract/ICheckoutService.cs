namespace SingleResponsibilityPrinciple.Abstract;

internal interface ICheckoutService
{
    float GetShoppingCartPrice(IShoppingCart shoppingCart);
}   