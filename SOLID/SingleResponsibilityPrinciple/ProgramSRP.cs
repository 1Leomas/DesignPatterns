using Org.BouncyCastle.Bcpg;
using SingleResponsibilityPrinciple;

var products = new List<Product>
{
    new() { Name = "Laptop", Price = 23100 },
    new() { Name = "Phone", Price = 6400 },
    new() { Name = "Mouse", Price = 540 }
};

var shoppingCart = new ShoppingCart();

shoppingCart.AddProduct(products[0]);
shoppingCart.AddProduct(products[1]);
shoppingCart.AddProduct(products[2]);

shoppingCart.RemoveProduct(products[2]);

Console.WriteLine("Shopping card items:");
foreach (var item in shoppingCart.Items)
{
    Console.WriteLine(item);
    Console.WriteLine();
}

var checkout = new Checkout();

var totalPrice = checkout.GetShoppingCardPrice(shoppingCart);
Console.WriteLine("Total price to pay: {0}", totalPrice);