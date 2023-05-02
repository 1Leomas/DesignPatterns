using FactoryMethodWithBuilderAndPrototype.Entities;

namespace FactoryMethodWithBuilderAndPrototype.Abstract;

public interface IRaportFactory
{
    IRaport CreateRaport(Raport raport);
}