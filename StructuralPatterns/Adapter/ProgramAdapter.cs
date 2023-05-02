using Adapter;
using FactoryMethodWithBuilderAndPrototype.Abstract;
using FactoryMethodWithBuilderAndPrototype.Entities;
using FactoryMethodWithBuilderAndPrototype.Factories;

var raport = new Raport
{
    Name = "Studentii din camera 203A",
    Headers = new List<string>()
    {
        "Nume",
        "Prenume",
        "Varsta"
    },
    Body = new List<List<string>>()
    {
        new(){ "Tentiuc", "Ion", "21" },
        new(){ "Raileanu", "Daniel", "20" },
        new(){ "Babaian", "Victor", "21" }
    },
    Footer = "Caminul 2"
};

IRaportFactory pdfRaportFactory = new PdfRaportFactory();
var pdfRaport = pdfRaportFactory.CreateRaport(raport);

IRaportConsolePrinterAdapter adapter = new PdfRaportConsolePrinterAdapter();
adapter.Print(pdfRaport);