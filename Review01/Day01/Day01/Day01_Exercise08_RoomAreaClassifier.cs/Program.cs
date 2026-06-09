using System;
using System.Collections.Generic;

namespace BimExercises
{
    internal class Room
    {
        public string Name { get; set; }
        public double Area { get; set; }

        public Room(string name, double area)
        {
            Name = name;
            Area = area;
        }
    }

    internal class Program
    {
        static string GetRoomType(double area)
        {
            if (area < 20)
            {
                return "Small";
            }
            else if (area <= 50)
            {
                return "Medium";
            }
            else
            {
                return "Large";
            }
        }

        static void Main(string[] args)
        {
            List<Room> rooms = new List<Room>();

            int smallCount = 0;
            int mediumCount = 0;
            int largeCount = 0;

            Console.WriteLine("Enter number of rooms:");
            int roomCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= roomCount; i++)
            {
                Console.WriteLine($"Enter room name #{i}:");
                string roomName = Console.ReadLine();

                Console.WriteLine($"Enter room area #{i}:");
                double roomArea = double.Parse(Console.ReadLine());

                Room room = new Room(roomName, roomArea);
                rooms.Add(room);
            }

            Console.WriteLine();
            Console.WriteLine("===== Room Area Classification Report =====");

            foreach (Room room in rooms)
            {
                string roomType = GetRoomType(room.Area);

                Console.WriteLine($"Room: {room.Name}, Area: {room.Area}, Type: {roomType}");

                if (roomType == "Small")
                {
                    smallCount++;
                }
                else if (roomType == "Medium")
                {
                    mediumCount++;
                }
                else
                {
                    largeCount++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Small Rooms: {smallCount}");
            Console.WriteLine($"Medium Rooms: {mediumCount}");
            Console.WriteLine($"Large Rooms: {largeCount}");
        }
    }
}
