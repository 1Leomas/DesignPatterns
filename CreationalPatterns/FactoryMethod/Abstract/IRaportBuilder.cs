namespace FactoryMethod.Abstract;

internal interface IRaportBuilder
{
    IRaportBuilder CreateHeaders();
    IRaportBuilder CreateBody();
    IRaportBuilder CreateFooter();
    IRaport Build();
}