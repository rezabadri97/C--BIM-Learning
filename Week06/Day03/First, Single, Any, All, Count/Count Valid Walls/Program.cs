using System;
using System.Collections.Generic;
using System.Linq;

public class WallInfo
{
    public string Name { get; set; }
    public double Height { get; set; }
    public string LevelName { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<WallInfo> walls = new List<WallInfo>
        {
            new WallInfo { Name = "Wall A", Height = 2000, LevelName = "Level 1" },
            new WallInfo { Name = "Wall B", Height = 3000, LevelName = "Level 1" },
            new WallInfo { Name = "Wall C", Height = 3500, LevelName = "Level 2" },
            new WallInfo { Name = "Wall D", Height = 2200, LevelName = "Level 2" }
        };

        int tallWallCount = walls.Count(w => w.Height > 2500);

        Console.WriteLine("Tall wall count:");
        Console.WriteLine(tallWallCount);
    }
}
