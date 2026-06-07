using System;

namespace BimDeveloperExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter wall name:");
            string wallName = Console.ReadLine();

            Console.WriteLine("Enter wall length in meters:");
            double wallLength = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter wall height in meters:");
            double wallHeight = double.Parse(Console.ReadLine());

            double wallArea = wallLength * wallHeight;

            string wallCategory;

            if (wallArea < 10)
            {
                wallCategory = "Small Wall";
            }
            else if (wallArea >= 10 && wallArea <= 30)
            {
                wallCategory = "Medium Wall";
            }
            else
            {
                wallCategory = "Large Wall";
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine($"Wall Name: {wallName}");
            Console.WriteLine($"Length: {wallLength} m");
            Console.WriteLine($"Height: {wallHeight} m");
            Console.WriteLine($"Area: {wallArea} m²");
            Console.WriteLine($"Category: {wallCategory}");
        }
    }
}
