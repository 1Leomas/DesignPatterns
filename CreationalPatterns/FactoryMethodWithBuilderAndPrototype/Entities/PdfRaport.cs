﻿using FactoryMethodWithBuilderAndPrototype.Abstract;

namespace FactoryMethodWithBuilderAndPrototype.Entities;

public class PdfRaport : IRaport
{
    public string? Name { get; set; }
    public string ContentType { get; set; }
    public string? Header { get; set; }
    public string? Body { get; set; }
    public string? Footer { get; set; }

    public PdfRaport()
    {
        ContentType = "Pdf";
    }

    public void Print()
    {
        if (!string.IsNullOrEmpty(Header)) 
            Console.Write(Header);
        if (!string.IsNullOrEmpty(Body))
            Console.Write(Body);
        if (!string.IsNullOrEmpty(Footer)) 
            Console.WriteLine(Footer);
    }

    public IRaport Clone()
    {
        return new PdfRaport()
        {
            Name = this.Name,
            ContentType = this.ContentType,
            Header = this.Header,
            Body = this.Body,
            Footer = this.Footer
        };
    }
}