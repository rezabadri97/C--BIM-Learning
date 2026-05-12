using System;
using System.Collections.Generic;

public class Room
{
    public string Name;
    public int Height;

    public Room(string name, int height)
    {
        Name = name;
        Height = height;
    }

    public void ShowInfo()
    {
        Console.WriteLine("Room Name: " + Name);
        Console.WriteLine("Room Height: " + Height + " mm");
    }
}

public class Repository<T>
{
    private List<T> _items = new List<T>();

    public void Add(T item)
    {
        _items.Add(item);
    }

    public List<T> GetAll()
    {
        return _items;
    }

    public int Count()
    {
        return _items.Count;
    }
}

public class Program
{
    public static void Main()
    {
        Repository<Room> roomRepository = new Repository<Room>();

        Console.Write("Enter room name: ");
        string roomName = Console.ReadLine();

        Console.Write("Enter room height in mm: ");
        string inputHeight = Console.ReadLine();

        bool success = int.TryParse(inputHeight, out int roomHeight);

        if (!success)
        {
            Console.WriteLine("Invalid height. Room was not created.");
        }
        else if (roomHeight <= 0)
        {
            Console.WriteLine("Height must be greater than zero.");
        }
        else
        {
            Room room = new Room(roomName, roomHeight);
            roomRepository.Add(room);

            Console.WriteLine("Room added successfully.");
            Console.WriteLine("Room count: " + roomRepository.Count());

            foreach (Room item in roomRepository.GetAll())
            {
                item.ShowInfo();
            }
        }
    }
}
