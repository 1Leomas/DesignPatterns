namespace SingleResponsibilityPrinciple.Abstract;

internal interface IProduct
{
    public string Name { get; set; }
    public float GetPrice();
}