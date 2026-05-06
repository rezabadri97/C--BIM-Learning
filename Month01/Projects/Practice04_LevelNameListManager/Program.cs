using System;
using System.Collections.Generic;
class Level
{
    static void Main(string[] args)
    {
        List<string> levels = new List<string>();
        
        levels.Add("Level 01");
        levels.Add("Level 02");
        levels.Add("Level 03");
        levels.Add("Roof");

        for (int i=1; i<6; ++i)
        {
            string newLevel = $"Level 0{i}";
            if (!levels.Contains(newLevel))
            {
                levels.Add(newLevel);
            }
        }

        levels.Remove("Roof");
        
        
        DisplayInfo(levels);
    }
    static void DisplayInfo(List<string> levels)
    {
        for (int i = 0; i < levels.Count; ++i)
        {
            Console.WriteLine($"{i+1}- Level Name: {levels[i]}");
        }
    }
}