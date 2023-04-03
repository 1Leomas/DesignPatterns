using FactoryMethod.Abstract;
using FactoryMethod.Builders;
using FactoryMethod.Entities;

namespace FactoryMethod.Factories;

internal class PdfRaportFactory : IRaportFactory
{

    public IRaport CreateRaport(Raport raport)
    {
        IRaportBuilder builder = new PdfRaportBuilder(raport);

        var pdfRaport = builder.CreateHeader().CreateBody().CreateFooter().Build();

        return pdfRaport;
    }
}