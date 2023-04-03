using FactoryMethod.Abstract;
using FactoryMethod.Entities;
using System.Text;

namespace FactoryMethod.Builders;

internal class XmlRaportBuilder : IRaportBuilder
{
    private XmlRaport _xmlRaport;

    private readonly Raport _raport;

    public XmlRaportBuilder(Raport raport)
    {
        _xmlRaport = new XmlRaport();

        _raport = raport;
    }

    public IRaportBuilder CreateHeader()
    {
        _xmlRaport.Header = $"<title>{_raport.Name}</title>\n";

        return this;
    }

    public IRaportBuilder CreateBody()
    {
        var stringBuilder = new StringBuilder();

        stringBuilder.Append("<body>\n");
        for (var index = 0; index < _raport.Body.Count; index++)
        {
            var row = _raport.Body[index];
            stringBuilder.Append("\t<p>");
            for (int i = 0; i < row.Count; i++)
            {
                var cell = row[i];
                var header = _raport.Headers[i];
                stringBuilder.Append($" {cell} ");
            }
            stringBuilder.Append("</p>\n");
        }
        stringBuilder.Append("</body>\n");

        _xmlRaport.Body = stringBuilder.ToString();

        return this;
    }

    public IRaportBuilder CreateFooter()
    {
        var stringBuilder = new StringBuilder();

        stringBuilder.Append($"<footer>\n\t{_raport.Footer}\n</footer>");

        _xmlRaport.Footer = stringBuilder.ToString();

        return this;
    }

    public IRaport Build()
    {
        var excelRaport = _xmlRaport;
        excelRaport.Name = _raport.Name;

        Reset();

        return excelRaport;
    }

    public void Reset()
    {
        _xmlRaport = new XmlRaport();
    }
}