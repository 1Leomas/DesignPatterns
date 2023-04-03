using FactoryMethod.Abstract;
using FactoryMethod.Builders;
using FactoryMethod.Entities;
using FactoryMethod.Factories;


var raport = new Raport
{
    Name = "Candidatii nr.2 pentru participare la turneu",
    Headers = new List<string>()
    {
        "Nume",
        "Prenume",
        "Varsta"
    },
    Body = new List<List<string>>()
    {
        new(){ "Ion", "Tuc", "21" },
        new(){ "Danu", "Tuc", "20" },
        new(){ "Vituc", "Tuc", "21" }
    },
    Footer = "TeamTuc 2023"
};


IRaportFactory excelRaportFactory = new ExcelRaportFactory();
var excelRaport = excelRaportFactory.CreateRaport(raport);
Console.WriteLine("EXCEL RAPORT:");
excelRaport.Print();

IRaportFactory pdfRaportFactory = new PdfRaportFactory();
var pdfRaport = pdfRaportFactory.CreateRaport(raport);
Console.WriteLine();
Console.WriteLine("PDF RAPORT:");
pdfRaport.Print();

IRaportFactory xmlRaportFactory = new XmlRaportFactory();
var xmlRaport = xmlRaportFactory.CreateRaport(raport);
Console.WriteLine();
Console.WriteLine("XML RAPORT:");
xmlRaport.Print();
