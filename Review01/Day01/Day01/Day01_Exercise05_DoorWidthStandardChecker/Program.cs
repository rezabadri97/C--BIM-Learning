using System;
using System.Collections.Generic;

namespace BimDeveloperExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double minimumStandardWidth = 0.9;

            List<string> doorCodes = new List<string>();
            List<double> doorWidths = new List<double>();
            List<string> notStandardDoors = new List<string>();

            int standardDoorCount = 0;
            int notStandardDoorCount = 0;
            double totalWidth = 0;

            Console.WriteLine("Enter number of doors:");
            int doorCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= doorCount; i++)
            {
                Console.WriteLine($"Enter door code #{i}:");
                string doorCode = Console.ReadLine();

                Console.WriteLine($"Enter door width #{i} in meters:");
                double doorWidth = double.Parse(Console.ReadLine());

                doorCodes.Add(doorCode);
                doorWidths.Add(doorWidth);

                totalWidth += doorWidth;

                if (doorWidth >= minimumStandardWidth)
                {
                    standardDoorCount++;
                    Console.WriteLine($"Door {doorCode} is Standard");
                }
                else
                {
                    notStandardDoorCount++;
                    notStandardDoors.Add(doorCode);
                    Console.WriteLine($"Door {doorCode} is Not Standard");
                }

                Console.WriteLine();
            }

            double averageWidth = totalWidth / doorCount;

            Console.WriteLine("=========== Door Width Report ===========");
            Console.WriteLine($"Total Doors: {doorCount}");
            Console.WriteLine($"Standard Doors: {standardDoorCount}");
            Console.WriteLine($"Not Standard Doors: {notStandardDoorCount}");
            Console.WriteLine($"Total Width: {totalWidth}");
            Console.WriteLine($"Average Width: {averageWidth}");

            Console.WriteLine();
            Console.WriteLine("Not Standard Door List:");

            if (notStandardDoors.Count == 0)
            {
                Console.WriteLine("All doors are standard.");
            }
            else
            {
                foreach (string doorCode in notStandardDoors)
                {
                    Console.WriteLine(doorCode);
                }
            }
        }
    }
}
