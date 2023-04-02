using System.Text;
using FactoryMethod.Abstract;
using FactoryMethod.Entities;

namespace FactoryMethod.Factories;

internal class ExcelRaportFactory : IRaportFactory
{
    private string CreateHeaders(List<string> raportHeaders, int[] headersLength, int lengthHeader)
    {
        var stringBuilder = new StringBuilder();

        for (int i = 0; i < lengthHeader; i++)
            stringBuilder.Append('-');

        stringBuilder.AppendLine();
        for (int j = 0; j < raportHeaders.Count; j++)
        {
            var cell = raportHeaders[j];

            for (int k = 0; k < headersLength[j] - cell.Length; k++)
            {
                stringBuilder.Append(' ');
            }

            stringBuilder.Append($"{cell}");

            if (j != raportHeaders.Count - 1)
                stringBuilder.Append(" | ");
        }

        stringBuilder.AppendLine();
        for (int i = 0; i < lengthHeader; i++)
            stringBuilder.Append('-');

        return stringBuilder.ToString();
    }

    private string CreateBody(List<List<string>> raportBody, int[] headersLength)
    {
        var stringBuilder = new StringBuilder();

        for (var i = 0; i < raportBody.Count; i++)
        {
            var row = raportBody[i];

            for (int j = 0; j < row.Count; j++)
            {
                var cell = row[j];

                for (int k = 0; k < headersLength[j] - cell.Length; k++)
                {
                    stringBuilder.Append(' ');
                }

                stringBuilder.Append($"{cell}");

                if(j != raportBody.Count-1)
                    stringBuilder.Append(" | ");
            }

            if (i != raportBody.Count - 1)
                stringBuilder.AppendLine();
        }

        return stringBuilder.ToString();
    }

    private string CreateFooter(string footer, int lengthHeader)
    {
        var stringBuilder = new StringBuilder();

        for (int i = 0; i < lengthHeader; i++)
            stringBuilder.Append('-');
        
        stringBuilder.AppendLine();
        stringBuilder.Append(footer);

        return stringBuilder.ToString();
    }

    public IRaport CreateRaport(Raport raport)
    {
        var headersMaxLength = raport.Headers.Select(x => x.Length).ToArray();
        foreach (var row in raport.Body)
        {
            for (var j = 0; j < row.Count; j++)
            {
                var cellLength = row[j].Length;
                if (cellLength > headersMaxLength[j])
                    headersMaxLength[j] = cellLength;
            }
        }
        var lengthHeader = 3 * (raport.Headers.Count - 1) + headersMaxLength.Sum();

        var excelRaport = new ExcelRaport
        {
            Name = raport.Name,
            Header = CreateHeaders(raport.Headers, headersMaxLength, lengthHeader),
            Body = CreateBody(raport.Body, headersMaxLength),
            Footer = CreateFooter(raport.Footer, lengthHeader)
        };

        return excelRaport;
    }
}