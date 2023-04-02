using FactoryMethod.Abstract;
using FactoryMethod.Entities;

namespace FactoryMethod.Factories;

internal class XmlRaportFactory //: IRaportFactory
{


    public IRaport CreateRaport()
    {
        return new XmlRaport();
    }
}