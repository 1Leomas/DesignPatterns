using System.Text;

namespace Memento;

internal static class NameGenerator
{
    public static string Generate(int length)
    {
        var vowels = new[] { 'a', 'e', 'i', 'o', 'u', 'y' };
        var consonants = new[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k',
            'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };
        var random = new Random(DateTime.Now.Second);
        var sb = new StringBuilder();

        //initialize our vowel/consonant flag
        bool flag = (random.Next(2) == 0);
        for (var i = 0; i < length; i++)
        {
            sb.Append(GetChar(flag));
            flag = !flag; //invert the vowel/consonant flag
        }

        sb[0] = char.ToUpper(sb[0]);

        return sb.ToString();

        char GetChar(bool vowel)
        {
            return vowel 
                ? vowels[random.Next(vowels.Length)] 
                : consonants[random.Next(consonants.Length)];
        }
    }
}