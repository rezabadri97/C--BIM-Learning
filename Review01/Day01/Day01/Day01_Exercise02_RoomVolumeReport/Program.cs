using System;

namespace BimDeveloperExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalVolume = 0;
            int roomCount = 3;

            for (int i = 1; i <= roomCount; i++)
            {
                Console.WriteLine($"Enter room #{i} name:");
                string roomName = Console.ReadLine();

                Console.WriteLine("Enter room length in meters:");
                double length = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter room width in meters:");
                double width = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter room height in meters:");
                double height = double.Parse(Console.ReadLine());

                double volume = length * width * height;
                totalVolume += volume;

                string category;

                if (volume < 30)
                {
                    category = "Small Room";
                }
                else if (volume <= 80)
                {
                    category = "Medium Room";
                }
                else
                {
                    category = "Large Room";
                }

                Console.WriteLine("----------- Room Result -----------");
                Console.WriteLine($"Room Name: {roomName}");
                Console.WriteLine($"Length: {length} m");
                Console.WriteLine($"Width: {width} m");
                Console.WriteLine($"Height: {height} m");
                Console.WriteLine($"Volume: {volume} m³");
                Console.WriteLine($"Category: {category}");
                Console.WriteLine();
            }

            double averageVolume = totalVolume / roomCount;

            Console.WriteLine("=========== Final Report ===========");
            Console.WriteLine($"Total Volume: {totalVolume} m³");
            Console.WriteLine($"Average Volume: {averageVolume} m³");
        }
    }
}
