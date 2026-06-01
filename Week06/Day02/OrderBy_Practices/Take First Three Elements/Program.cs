using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<string> elementNames = new List<string>
        {
            "Wall A",
            "Door A",
            "Window A",
            "Column A",
            "Floor A"
        };

        var firstThree = elementNames.Take(3);

        Console.WriteLine("First Three Elements:");
        foreach (var name in firstThree)
        {
            Console.WriteLine(name);
        }
    }
}
