using FactoryMethodWithBuilderAndPrototype.Abstract;
using FactoryMethodWithBuilderAndPrototype.Builders;
using FactoryMethodWithBuilderAndPrototype.Entities;

namespace FactoryMethodWithBuilderAndPrototype.Factories;

public class PdfRaportFactory : IRaportFactory
{
    public IRaport CreateRaport(Raport raport)
    {
        IRaportBuilder builder = new PdfRaportBuilder(raport);

        var pdfRaport = builder.CreateHeader().CreateBody().CreateFooter().Build();

        return pdfRaport;
    }
}