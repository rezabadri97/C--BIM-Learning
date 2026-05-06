using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> levels = new List<string>();

        AddLevel(levels, "Level 1");
        AddLevel(levels, "Level 2");
        AddLevel(levels, "Roof");
        AddLevel(levels, "Level 2");

        RemoveLevel(levels, "Roof");

        Console.WriteLine("Has Level 1? " + levels.Contains("Level 1"));
        Console.WriteLine("Total Levels: " + levels.Count);

        foreach (string level in levels)
        {
            Console.WriteLine(level);
        }
    }

    static void AddLevel(List<string> levels, string levelName)
    {
        if (!levels.Contains(levelName))
        {
            levels.Add(levelName);
        }
        else
        {
            Console.WriteLine("Duplicate level not added: " + levelName);
        }
    }

    static void RemoveLevel(List<string> levels, string levelName)
    {
        if (levels.Contains(levelName))
        {
            levels.Remove(levelName);
        }
    }
}
