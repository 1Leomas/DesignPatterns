using System.Text;
using System.Xml.Linq;
using FactoryMethod.Abstract;
using FactoryMethod.Builders;
using FactoryMethod.Entities;

namespace FactoryMethod.Factories;

internal class ExcelRaportFactory : IRaportFactory
{
    public IRaport CreateRaport(Raport raport)
    {
        IRaportBuilder builder = new ExcelRaportBuilder(raport);

        var excelRaport = builder.CreateHeader().CreateBody().CreateFooter().Build();

        return excelRaport;
    }
}