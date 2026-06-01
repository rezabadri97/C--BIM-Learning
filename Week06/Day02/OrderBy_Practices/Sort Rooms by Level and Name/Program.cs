using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

public class RoomInfo
{
    public string LevelName { get; set; }
    public string RoomName { get; set; }
    public double Area { get; set; }
}
public class Program
{
    public static void Main(string[] args)
    {
        List<RoomInfo> rooms = new List<RoomInfo>
    {
        new RoomInfo{LevelName="Level 2", RoomName="Office", Area=30},
        new RoomInfo{LevelName="Level 1", RoomName="Lobby", Area=50},
        new RoomInfo{LevelName="Level 1", RoomName="Office", Area=25},
        new RoomInfo{LevelName="Level 2", RoomName="Meeting", Area=20},

    };
        var sortedRooms = rooms.OrderBy(r => r.LevelName).ThenBy(r => r.RoomName);

        foreach (var room in sortedRooms)
        {
            Console.WriteLine($"Level Name: {room.LevelName} | Room Name: {room.RoomName} | Room Area: {room.Area}");
        }




 }
}