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
            new WallInfo { Name = "Wall C", Height = 3000, LevelName = "Level 2" },
            new WallInfo { Name = "Wall A", Height = 2500, LevelName = "Level 1" },
            new WallInfo { Name = "Wall B", Height = 3000, LevelName = "Level 1" },
            new WallInfo { Name = "Wall D", Height = 4000, LevelName = "Level 3" },
            new WallInfo { Name = "Wall E", Height = 2000, LevelName = "Level 1" }
        };

        var result = walls
            .Where(w => w.Height > 2500)
            .OrderBy(w => w.Height)
            .ThenBy(w => w.Name)
            .Take(2);

        Console.WriteLine("Filtered, Sorted, and Limited Walls:");
        foreach (var wall in result)
        {
            Console.WriteLine($"{wall.Name} - {wall.Height} - {wall.LevelName}");
        }
    }
}
