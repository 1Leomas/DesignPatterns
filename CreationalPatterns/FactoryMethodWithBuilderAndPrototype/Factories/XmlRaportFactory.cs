using FactoryMethodWithBuilderAndPrototype.Abstract;
using FactoryMethodWithBuilderAndPrototype.Builders;
using FactoryMethodWithBuilderAndPrototype.Entities;

namespace FactoryMethodWithBuilderAndPrototype.Factories;

public class XmlRaportFactory : IRaportFactory
{
    public IRaport CreateRaport(Raport raport)
    {
        IRaportBuilder builder = new XmlRaportBuilder(raport);

        var xmlRaport = builder.CreateHeader().CreateBody().CreateFooter().Build();

        return xmlRaport;
    }
}