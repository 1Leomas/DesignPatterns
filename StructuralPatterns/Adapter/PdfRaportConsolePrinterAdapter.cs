using System.Text.RegularExpressions;
using FactoryMethodWithBuilderAndPrototype.Abstract;
using FactoryMethodWithBuilderAndPrototype.Entities;
using FactoryMethodWithBuilderAndPrototype.Factories;

namespace Adapter;

public class PdfRaportConsolePrinterAdapter : IRaportConsolePrinterAdapter
{
    private RaportConsolePrinter raportConsolePrinter = new RaportConsolePrinter();

    public void Print(IRaport raport)
    {
        var raportName = Regex.Replace(raport.Name, @"(^Denumire raport: )(.*)", "$2");
        var raportHeaders = Regex.Matches(raport.Body, @"(\w+):").Select(x => x.Result("$1")).Take(3).ToList();
        var allBodyData = Regex.Matches(raport.Body, @":\s(\w+)").Select(x => x.Result("$1")).ToList();
        var raportBody = new List<List<string>>();

        int counter = 0;
        var row = new List<string>();
        foreach (var item in allBodyData)
        {
            row.Add(item);
            counter++;

            if (counter == 3) 
            {
                raportBody.Add(row);
                counter = 0;
                row = new List<string>();
            }
        }

        var raportToPrint = new Raport()
        {
            Name = raportName,
            Headers = raportHeaders,
            Body = raportBody,
            Footer = raport.Footer
        };

        raportConsolePrinter.Print(raportToPrint);
    }
}