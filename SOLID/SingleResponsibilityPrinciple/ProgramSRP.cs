using SingleResponsibilityPrinciple;
using SingleResponsibilityPrinciple.Abstract;
using SingleResponsibilityPrinciple.Products;
    
var products = new List<IProduct>()
{
    new Laptop("Laptop", 23100),
    new Phone("Phone", 6400),
    new Mouse("Mouse", 540)
};

IShoppingCart shoppingCart = new ShoppingCart();

shoppingCart.AddProduct(products[0]);
shoppingCart.AddProduct(products[1]);
shoppingCart.AddProduct(products[2]);

shoppingCart.RemoveProduct(products[2]);

Console.WriteLine("Shopping card items:");
foreach (var item in shoppingCart.GetItems())
{
    Console.WriteLine(item);
    Console.WriteLine();
}

ICheckoutService checkout = new Checkout();

var totalPrice = checkout.GetShoppingCartPrice(shoppingCart);
Console.WriteLine("Total price to pay: {0}", totalPrice);