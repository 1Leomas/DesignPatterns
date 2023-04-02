using FactoryMethod.Abstract;
using FactoryMethod.Entities;

namespace FactoryMethod.Factories;

internal class PdfRaportFactory : IRaportFactory
{

    public IRaport CreateRaport(Raport raport)
    {
        return new PdfRaport();
    }
}