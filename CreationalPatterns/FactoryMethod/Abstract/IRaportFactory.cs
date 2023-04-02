using FactoryMethod.Entities;

namespace FactoryMethod.Abstract;

internal interface IRaportFactory
{
    IRaport CreateRaport(Raport raport);
}