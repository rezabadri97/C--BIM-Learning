using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<string> levels = new List<string>
        {
            "Basement",
            "Ground Floor",
            "Level 1",
            "Level 2",
            "Roof"
        };

        var result = levels.Skip(2).Take(2);

        Console.WriteLine("Skipped first two, then took next two:");
        foreach (var level in result)
        {
            Console.WriteLine(level);
        }
    }
}
