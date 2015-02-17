using System;
using System.Linq;

class MaximalSequence
{
    //•	Write a program that finds the maximal sequence of equal elements in an array.
    static void Main()
    {
        var seq = new int[] { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

        int[] max = seq.Select((n, i) => new { Value = n, Index = i })
            .OrderBy(s => s.Value)
            .Select((o, i) => new { Value = o.Value, Diff = i - o.Index })
            .GroupBy(s => new { s.Value, s.Diff })
            .OrderByDescending(g => g.Count())
            .First()
            .Select(f => f.Value)
            .ToArray();
        max.ToList().ForEach(i => Console.Write(i.ToString() + " "));
    }
}
