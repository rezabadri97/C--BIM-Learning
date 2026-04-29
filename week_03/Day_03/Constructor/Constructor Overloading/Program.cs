using System;

class Room
{
    public string Name { get; set; }
    public double Area { get; set; }

    public Room()
    {
        Name = "Unnamed Room";
        Area = 0;
    }

    public Room(string roomName, double roomArea)
    {
        Name = roomName;
        Area = roomArea;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Room room1 = new Room();
        Room room2 = new Room("Office", 25.5);

        Console.WriteLine("Room 1: " + room1.Name + ", " + room1.Area);
        Console.WriteLine("Room 2: " + room2.Name + ", " + room2.Area);
    }
}
