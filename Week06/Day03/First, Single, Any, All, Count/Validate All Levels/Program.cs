using System;
using System.Collections.Generic;
using System.Linq;

public class LevelInfo
{
    public string Name { get; set; }
    public double Elevation { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<LevelInfo> levels = new List<LevelInfo>
        {
            new LevelInfo { Name = "Ground Floor", Elevation = 0 },
            new LevelInfo { Name = "Level 1", Elevation = 3000 },
            new LevelInfo { Name = "Level 2", Elevation = 6000 }
        };

        bool allLevelsValid = levels.All(l => l.Elevation >= 0);

        Console.WriteLine("All levels valid:");
        Console.WriteLine(allLevelsValid);
    }
}
