using System;

internal class BigRoom
{
    public string RoomName { get; set; }
    public string RoomNumber { get; set; }
    public string DepartmentName { get; set; }

    private double area;
    public double Area
    {
        get => area;
        set
        {
            if (value > 0)
                area = value;
            else
                Console.WriteLine("Area must be greater than zero.");
        }
    }

    public void RenameRoom(string newName)
    {
        if (string.IsNullOrWhiteSpace(newName))
        {
            Console.WriteLine("New name cannot be empty.");
            return;
        }

        RoomName = newName;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Room Name: {RoomName}");
        Console.WriteLine($"Room Number: {RoomNumber}");
        Console.WriteLine($"Department Name: {DepartmentName}");
        Console.WriteLine($"Area: {Area}");
        Console.WriteLine("-------------------");
    }
}

class Program
{
    static void Main(string[] args)
    {
        BigRoom room1 = new BigRoom();
        room1.RoomName = "Kitchen";
        room1.RoomNumber = "1";
        room1.DepartmentName = "Architecture";
        room1.Area = 15;
        room1.RenameRoom("Bedroom");

        BigRoom room2 = new BigRoom();
        room2.RoomName = "Living Room";
        room2.RoomNumber = "2";
        room2.DepartmentName = "Interior";
        room2.Area = 25;
        room2.RenameRoom("Guest Room");

        room1.ShowInfo();
        room2.ShowInfo();
    }
}
