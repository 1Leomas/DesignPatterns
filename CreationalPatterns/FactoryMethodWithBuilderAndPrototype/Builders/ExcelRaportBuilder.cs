using FactoryMethod.Abstract;
using FactoryMethod.Entities;
using System.Text;

namespace FactoryMethod.Builders;

internal class ExcelRaportBuilder : IRaportBuilder
{
    private ExcelRaport _excelRaport;

    private Raport _raport;
    private List<int> _headersMaxLength;
    private int _rowLength;

    public ExcelRaportBuilder(Raport raport)
    {
        _excelRaport = new ExcelRaport();

        _raport = raport;

        _headersMaxLength = raport.Headers.Select(x => x.Length).ToList();
        foreach (var row in raport.Body)
        {
            for (var j = 0; j < row.Count; j++)
            {
                var cellLength = row[j].Length;
                if (cellLength > _headersMaxLength[j])
                    _headersMaxLength[j] = cellLength;
            }
        }
        _rowLength = 3 * (raport.Headers.Count - 1) + _headersMaxLength.Sum();
    }

    public IRaportBuilder CreateHeader()
    {
        var stringBuilder = new StringBuilder();

        for (int i = 0; i < _rowLength; i++)
            stringBuilder.Append('-');

        stringBuilder.AppendLine();
        for (int j = 0; j < _raport.Headers.Count; j++)
        {
            var cell = _raport.Headers[j];

            for (int k = 0; k < _headersMaxLength[j] - cell.Length; k++)
            {
                stringBuilder.Append(' ');
            }

            stringBuilder.Append($"{cell}");

            if (j != _raport.Headers.Count - 1)
                stringBuilder.Append(" | ");
        }

        stringBuilder.AppendLine();
        for (int i = 0; i < _rowLength; i++)
            stringBuilder.Append('-');

        stringBuilder.AppendLine();

        _excelRaport.Header = stringBuilder.ToString();

        return this;
    }

    public IRaportBuilder CreateBody()
    {
        var stringBuilder = new StringBuilder();

        for (var i = 0; i < _raport.Body.Count; i++)
        {
            var row = _raport.Body[i];

            for (int j = 0; j < row.Count; j++)
            {
                var cell = row[j];

                for (int k = 0; k < _headersMaxLength[j] - cell.Length; k++)
                {
                    stringBuilder.Append(' ');
                }

                stringBuilder.Append($"{cell}");

                if (j != _raport.Body.Count - 1)
                    stringBuilder.Append(" | ");
            }

            stringBuilder.AppendLine();
        }

        _excelRaport.Body = stringBuilder.ToString();

        return this;
    }

    public IRaportBuilder CreateFooter()
    {
        var stringBuilder = new StringBuilder();

        for (int i = 0; i < _rowLength; i++)
            stringBuilder.Append('-');

        stringBuilder.AppendLine();
        stringBuilder.Append(_raport.Footer);

        _excelRaport.Footer = stringBuilder.ToString();

        return this;
    }

    public IRaport Build()
    {
        var excelRaport = _excelRaport;
        excelRaport.Name = _raport.Name;

        Reset();

        return excelRaport;
    }

    public void Reset()
    {
        _excelRaport = new ExcelRaport();
    }
}