namespace FactoryMethodWithBuilderAndPrototype.Abstract;

public interface IRaportBuilder
{
    IRaportBuilder CreateHeader();
    IRaportBuilder CreateBody();
    IRaportBuilder CreateFooter();
    IRaport Build();
}