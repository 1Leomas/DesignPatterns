using OpenClosedPrinciple;
using OpenClosedPrinciple.SortMethods;
using System.Diagnostics;

const int n = 20000;
var data = new int[n];
for (var i = 0; i < data.Length; i++)
    data[i] = new Random().Next(n);

var bubbleArray = data.Select(x => x).ToArray();
var quickArrayLomuto = data.Select(x => x).ToArray();
var quickArrayHoare = data.Select(x => x).ToArray();
var arrSys = data.Select(x => x).ToArray();

var stopwatch = Stopwatch.StartNew();
BubbleSort.Sort(bubbleArray);
stopwatch.Stop();
Console.WriteLine($"Bubble Sort executed in: {stopwatch.GetTimeString()}");

stopwatch = Stopwatch.StartNew();
QuickSortLomuto.Sort(quickArrayLomuto);
stopwatch.Stop();
Console.WriteLine($"Quick Sort Lomuto executed in: {stopwatch.GetTimeString()}");

stopwatch = Stopwatch.StartNew();
QuickSortHoare.Sort(quickArrayHoare);
stopwatch.Stop();
Console.WriteLine($"Quick Sort Hoare executed in: {stopwatch.GetTimeString()}");

stopwatch = Stopwatch.StartNew();
Array.Sort(arrSys);
stopwatch.Stop();
Console.WriteLine($"Sys Sort executed in: {stopwatch.GetTimeString()}");