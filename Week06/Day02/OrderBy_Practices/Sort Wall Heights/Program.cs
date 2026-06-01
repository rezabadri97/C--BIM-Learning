using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<double> wallHeights = new List<double> { 3000, 1500, 4500, 2500, 2000 };

        var sortedHeights = wallHeights.OrderBy(h => h);

        Console.WriteLine("Sorted Wall Heights:");
        foreach (var height in sortedHeights)
        {
            Console.WriteLine(height);
        }
    }
}
