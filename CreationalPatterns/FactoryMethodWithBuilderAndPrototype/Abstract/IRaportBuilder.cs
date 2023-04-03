namespace FactoryMethod.Abstract;

internal interface IRaportBuilder
{
    IRaportBuilder CreateHeader();
    IRaportBuilder CreateBody();
    IRaportBuilder CreateFooter();
    IRaport Build();
}