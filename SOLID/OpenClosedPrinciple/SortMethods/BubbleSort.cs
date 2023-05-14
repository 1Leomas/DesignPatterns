using OpenClosedPrinciple.Abstract;

namespace OpenClosedPrinciple.SortMethods;

internal class BubbleSort : ISort
{
    public static void Sort(int[] toSort)
    {
        var n = toSort.Length;
        for (var i = 0; i < n - 1; i++)
        {
            for (var j = 0; j < n - i - 1; j++)
            {
                if (toSort[j] > toSort[j + 1])
                {
                    Swap(ref toSort[j], ref toSort[j + 1]);
                }
            }
        }
    }

    private static void Swap(ref int a, ref int b)
    {
        (a, b) = (b, a);
    }
}