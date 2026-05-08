using System;

interface IExportable
{
    string ExportData();
}

class RoomData : IExportable
{
    public string Number { get; set; }
    public string Name { get; set; }

    public RoomData(string number, string name)
    {
        Number = number;
        Name = name;
    }

    public string ExportData()
    {
        return "Room => Number: " + Number + ", Name: " + Name;
    }
}

class DoorData : IExportable
{
    public string Code { get; set; }
    public double Width { get; set; }

    public DoorData(string code, double width)
    {
        Code = code;
        Width = width;
    }

    public string ExportData()
    {
        return "Door => Code: " + Code + ", Width: " + Width;
    }
}

class Program
{
    static void Main()
    {
        RoomData room = new RoomData("101", "Office");
        DoorData door = new DoorData("D-01", 1.1);

        Console.WriteLine(room.ExportData());
        Console.WriteLine(door.ExportData());
    }
}
