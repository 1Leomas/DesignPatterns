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


IRaportFactory raportFactory = new ExcelRaportFactory();

var finalRaport = raportFactory.CreateRaport(raport);


Console.WriteLine("EXCEL RAPORT:");
finalRaport.Print();