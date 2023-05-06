﻿using System.Text;
using SingleResponsibilityPrinciple.Abstract;

namespace SingleResponsibilityPrinciple.Products;

internal class Laptop: IProduct
{
    public string Name { get; set; }
    private float _price;

    public Laptop(string name, float price)
    {
        Name = name;
        _price = price;
    }

    public float GetPrice()
    {
        return _price;
    }

    public override string ToString()
    {
        StringBuilder sb = new();
        sb.Append($"Name: {Name}");
        sb.AppendLine();
        sb.Append($"Price: {_price}");
        return sb.ToString();
    }
}