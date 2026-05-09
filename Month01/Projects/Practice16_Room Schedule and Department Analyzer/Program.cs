using System;
using System.Collections.Generic;

interface IExportable
{
    string ExportData();
}

class RoomScheduleItem : IExportable
{
    private string _number;
    private string _name;
    private double _area;

    public string Number
    {
        get { return _number; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                _number = "UNKNOWN";
            else
                _number = value.Trim();
        }
    }

    public string Name
    {
        get { return _name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                _name = "Unnamed Room";
            else
                _name = value.Trim();
        }
    }

    public string Department { get; set; }
    public string Level { get; set; }

    public double Area
    {
        get { return _area; }
        set
        {
            if (value < 0)
                _area = 0;
            else
                _area = value;
        }
    }

    public RoomScheduleItem(string number, string name, string department, string level, double area)
    {
        Number = number;
        Name = name;
        Department = department;
        Level = level;
        Area = area;
    }

    public bool IsValid()
    {
        return !string.IsNullOrWhiteSpace(Department)
            && !string.IsNullOrWhiteSpace(Level)
            && Area > 0;
    }

    public string ExportData()
    {
        return Number + "," + Name + "," + Department + "," + Level + "," + Area;
    }

    public void Display()
    {
        Console.WriteLine("Room Number: " + Number);
        Console.WriteLine("Room Name: " + Name);
        Console.WriteLine("Department: " + Department);
        Console.WriteLine("Level: " + Level);
        Console.WriteLine("Area: " + Area);
        Console.WriteLine("----------------------");
    }
}

class RoomScheduleManager
{
    private List<RoomScheduleItem> _rooms = new List<RoomScheduleItem>();

    public void AddRoom(RoomScheduleItem room)
    {
        if (room == null)
        {
            Console.WriteLine("Room is null.");
            return;
        }

        if (!room.IsValid())
        {
            Console.WriteLine("Invalid room data: " + room.Number);
            return;
        }

        _rooms.Add(room);
    }

    public void ShowAllRooms()
    {
        foreach (RoomScheduleItem room in _rooms)
        {
            room.Display();
        }
    }

    public void ShowRoomsByDepartment(string department)
    {
        Console.WriteLine("Rooms in Department: " + department);

        foreach (RoomScheduleItem room in _rooms)
        {
            if (room.Department.Equals(department, StringComparison.OrdinalIgnoreCase))
            {
                room.Display();
            }
        }
    }

    public void ShowLargeRooms(double minArea)
    {
        Console.WriteLine("Rooms with area greater than " + minArea);

        foreach (RoomScheduleItem room in _rooms)
        {
            if (room.Area > minArea)
            {
                room.Display();
            }
        }
    }

    public void ShowDepartmentAreaSummary()
    {
        Dictionary<string, double> departmentAreas = new Dictionary<string, double>();

        foreach (RoomScheduleItem room in _rooms)
        {
            if (departmentAreas.ContainsKey(room.Department))
            {
                departmentAreas[room.Department] += room.Area;
            }
            else
            {
                departmentAreas.Add(room.Department, room.Area);
            }
        }

        Console.WriteLine("Department Area Summary:");
        foreach (var item in departmentAreas)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }

    public void ExportAllRooms()
    {
        Console.WriteLine("Exported Room Data:");
        foreach (RoomScheduleItem room in _rooms)
        {
            Console.WriteLine(room.ExportData());
        }
    }
}

class Program
{
    static void Main()
    {
        RoomScheduleManager manager = new RoomScheduleManager();

        manager.AddRoom(new RoomScheduleItem("101", "Office A", "Office", "Level 1", 35));
        manager.AddRoom(new RoomScheduleItem("102", "Meeting Room", "Office", "Level 1", 50));
        manager.AddRoom(new RoomScheduleItem("201", "Mechanical Room", "MEP", "Level 2", 28));
        manager.AddRoom(new RoomScheduleItem("202", "Electrical Room", "MEP", "Level 2", 22));
        manager.AddRoom(new RoomScheduleItem("301", "Lobby", "Public", "Ground Floor", 60));

        manager.ShowAllRooms();
        manager.ShowRoomsByDepartment("Office");
        manager.ShowLargeRooms(30);
        manager.ShowDepartmentAreaSummary();
        manager.ExportAllRooms();
    }
}
