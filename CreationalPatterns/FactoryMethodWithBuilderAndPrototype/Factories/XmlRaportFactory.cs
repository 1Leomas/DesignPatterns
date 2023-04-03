using FactoryMethod.Abstract;
using FactoryMethod.Builders;
using FactoryMethod.Entities;

namespace FactoryMethod.Factories;

internal class XmlRaportFactory : IRaportFactory
{
    public IRaport CreateRaport(Raport raport)
    {
        IRaportBuilder builder = new XmlRaportBuilder(raport);

        var xmlRaport = builder.CreateHeader().CreateBody().CreateFooter().Build();

        return xmlRaport;
    }
}