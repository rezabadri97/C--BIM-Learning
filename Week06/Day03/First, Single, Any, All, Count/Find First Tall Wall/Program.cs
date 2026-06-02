using System;
using System.Collections.Generic;
using System.Linq;

public class WallInfo
{
    public string Name { get; set; }
    public double Height { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<WallInfo> walls = new List<WallInfo>
        {
            new WallInfo { Name = "Wall A", Height = 2500 },
            new WallInfo { Name = "Wall B", Height = 3200 },
            new WallInfo { Name = "Wall C", Height = 4000 }
        };

        WallInfo firstTallWall = walls.First(w => w.Height > 3000);

        Console.WriteLine("First tall wall:");
        Console.WriteLine(firstTallWall.Name);
    }
}
