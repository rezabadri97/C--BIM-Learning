using System;
using System.Collections.Generic;

class BimRoom
{
    private string roomName;
    private double area;

    public string RoomNumber { get; set; }

    public string RoomName
    {
        get { return roomName; }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                roomName = value;
            }
            else
            {
                roomName = "Unnamed Room";
            }
        }
    }

    public double Area
    {
        get { return area; }
        set
        {
            if (value >= 0)
            {
                area = value;
            }
            else
            {
                area = 0;
            }
        }
    }

    public BimRoom(string roomNumber, string roomName, double area)
    {
        RoomNumber = roomNumber;
        RoomName = roomName;
        Area = area;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Room Number: " + RoomNumber);
        Console.WriteLine("Room Name: " + RoomName);
        Console.WriteLine("Area: " + Area);
        Console.WriteLine("------------------------");
    }
}

class Program
{
    static void Main()
    {
        List<BimRoom> rooms = new List<BimRoom>();

        rooms.Add(new BimRoom("101", "Office", 24.5));
        rooms.Add(new BimRoom("102", "Meeting Room", 18.0));
        rooms.Add(new BimRoom("103", "", 30.0));
        rooms.Add(new BimRoom("104", "Lobby", -5));

        Console.WriteLine("Rooms with Area > 20:");
        Console.WriteLine();

        foreach (BimRoom room in rooms)
        {
            if (room.Area > 20)
            {
                room.DisplayInfo();
            }
        }

        Console.WriteLine("Total Rooms: " + rooms.Count);
    }
}
