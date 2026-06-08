using System;
using System.Collections.Generic;

namespace BimDeveloperExercises
{
    internal class LevelInfo
    {
        public string Name { get; set; }
        public double Elevation { get; set; }

        public LevelInfo(string name, double elevation)
        {
            Name = name;
            Elevation = elevation;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<LevelInfo> levels = new List<LevelInfo>();

            Console.WriteLine("Enter number of levels:");
            int levelCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= levelCount; i++)
            {
                Console.WriteLine($"Enter level name #{i}:");
                string levelName = Console.ReadLine();

                Console.WriteLine($"Enter elevation #{i}:");
                double elevation = double.Parse(Console.ReadLine());

                LevelInfo level = new LevelInfo(levelName, elevation);
                levels.Add(level);
            }

            double totalElevation = 0;
            int negativeElevationCount = 0;

            LevelInfo highestLevel = levels[0];

            foreach (LevelInfo level in levels)
            {
                totalElevation += level.Elevation;

                if (level.Elevation < 0)
                {
                    negativeElevationCount++;
                }

                if (level.Elevation > highestLevel.Elevation)
                {
                    highestLevel = level;
                }
            }

            double averageElevation = totalElevation / levels.Count;

            Console.WriteLine();
            Console.WriteLine("=========== Level Report ===========");
            Console.WriteLine();

            foreach (LevelInfo level in levels)
            {
                Console.WriteLine($"{level.Name} - Elevation: {level.Elevation}");
            }

            Console.WriteLine();
            Console.WriteLine($"Highest Level: {highestLevel.Name}");
            Console.WriteLine($"Highest Elevation: {highestLevel.Elevation}");
            Console.WriteLine($"Negative Elevation Levels: {negativeElevationCount}");
            Console.WriteLine($"Average Elevation: {averageElevation}");
        }
    }
}
