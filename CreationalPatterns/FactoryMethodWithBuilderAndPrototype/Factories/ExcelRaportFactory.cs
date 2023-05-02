using FactoryMethodWithBuilderAndPrototype.Abstract;
using FactoryMethodWithBuilderAndPrototype.Builders;
using FactoryMethodWithBuilderAndPrototype.Entities;

namespace FactoryMethodWithBuilderAndPrototype.Factories;

public class ExcelRaportFactory : IRaportFactory
{
    public IRaport CreateRaport(Raport raport)
    {
        IRaportBuilder builder = new ExcelRaportBuilder(raport);

        var excelRaport = builder.CreateHeader().CreateBody().CreateFooter().Build();

        return excelRaport;
    }
}