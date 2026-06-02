using System;
using System.Collections.Generic;
using System.Linq;

public class RoomInfo
{
    public string Name { get; set; }
    public double Area { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<RoomInfo> rooms = new List<RoomInfo>
        {
            new RoomInfo { Name = "Office", Area = 25 },
            new RoomInfo { Name = "Lobby", Area = 0 },
            new RoomInfo { Name = "Meeting", Area = 18 }
        };

        bool hasInvalidRoom = rooms.Any(r => r.Area <= 0);

        Console.WriteLine("Has invalid room:");
        Console.WriteLine(hasInvalidRoom);
    }
}
