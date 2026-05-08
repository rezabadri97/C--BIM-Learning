using System;
using System.Collections.Generic;

class RoomScheduleItem
{
    public string Number { get; set; }
    public string Name { get; set; }
    public double Area { get; set; }
    public string Department { get; set; }

    public RoomScheduleItem(string number, string name, double area, string department)
    {
        Number = number;
        Name = name;
        Area = area;
        Department = department;
    }

    public void Display()
    {
        Console.WriteLine("Number: " + Number + ", Name: " + Name + ", Area: " + Area + ", Department: " + Department);
    }
}

class Program
{
    static void Main()
    {
        List<RoomScheduleItem> rooms = new List<RoomScheduleItem>();

        rooms.Add(new RoomScheduleItem("101", "Office", 22, "Admin"));
        rooms.Add(new RoomScheduleItem("102", "Meeting", 14, "Admin"));
        rooms.Add(new RoomScheduleItem("201", "Lab", 35, "Technical"));
        rooms.Add(new RoomScheduleItem("202", "Storage", 12, "Technical"));
        rooms.Add(new RoomScheduleItem("301", "Manager Room", 18, "Admin"));

        Console.WriteLine("Rooms with Area > 15:");
        foreach (RoomScheduleItem room in rooms)
        {
            if (room.Area > 15)
            {
                room.Display();
            }
        }

        Console.WriteLine();
        Console.WriteLine("Rooms in Admin Department:");
        foreach (RoomScheduleItem room in rooms)
        {
            if (room.Department == "Admin")
            {
                room.Display();
            }
        }

        Console.WriteLine();
        Console.WriteLine("Total Room Count: " + rooms.Count);
    }
}
