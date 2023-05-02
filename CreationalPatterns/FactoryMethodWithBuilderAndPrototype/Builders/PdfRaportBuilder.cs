using System.Text;
using FactoryMethodWithBuilderAndPrototype.Abstract;
using FactoryMethodWithBuilderAndPrototype.Entities;

namespace FactoryMethodWithBuilderAndPrototype.Builders;

public class PdfRaportBuilder : IRaportBuilder
{
    private PdfRaport _pdfRaport;

    private readonly Raport _raport;

    public PdfRaportBuilder(Raport raport)
    {
        _pdfRaport = new PdfRaport();

        _raport = raport;
    }

    public IRaportBuilder CreateHeader()
    {
        _pdfRaport.Header = $"Denumire raport: {_raport.Name}\n";

        return this;
    }

    public IRaportBuilder CreateBody()
    {
        var stringBuilder = new StringBuilder();

        for (var index = 0; index < _raport.Body.Count; index++)
        {
            var row = _raport.Body[index];
            for (int i = 0; i < row.Count; i++)
            {
                var cell = row[i];
                var header = _raport.Headers[i];
                stringBuilder.Append($"{header}: {cell} ");
            }
            stringBuilder.AppendLine();
        }

        _pdfRaport.Body = stringBuilder.ToString();

        return this;
    }

    public IRaportBuilder CreateFooter()
    {
        var stringBuilder = new StringBuilder();

        stringBuilder.Append(_raport.Footer);

        _pdfRaport.Footer = stringBuilder.ToString();

        return this;
    }

    public IRaport Build()
    {
        var excelRaport = _pdfRaport;
        excelRaport.Name = _raport.Name;

        Reset();

        return excelRaport;
    }

    public void Reset()
    {
        _pdfRaport = new PdfRaport();
    }
}