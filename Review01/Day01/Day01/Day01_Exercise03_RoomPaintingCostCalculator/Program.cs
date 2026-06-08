using System;

namespace BimDeveloperExercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter room name:");
            string roomName = Console.ReadLine();

            Console.WriteLine("Enter number of walls:");
            int wallCount = int.Parse(Console.ReadLine());

            double totalWallArea = 0;

            for (int i = 1; i <= wallCount; i++)
            {
                Console.WriteLine($"Enter length for wall #{i} in meters:");
                double wallLength = double.Parse(Console.ReadLine());

                Console.WriteLine($"Enter height for wall #{i} in meters:");
                double wallHeight = double.Parse(Console.ReadLine());

                double wallArea = wallLength * wallHeight;
                totalWallArea += wallArea;

                Console.WriteLine($"Wall #{i} Area: {wallArea} m²");
                Console.WriteLine();
            }

            Console.WriteLine("Select paint quality:");
            Console.WriteLine("1. Economy Paint");
            Console.WriteLine("2. Standard Paint");
            Console.WriteLine("3. Premium Paint");

            int paintChoice = int.Parse(Console.ReadLine());

            string paintType;
            double pricePerSquareMeter;

            switch (paintChoice)
            {
                case 1:
                    paintType = "Economy Paint";
                    pricePerSquareMeter = 8;
                    break;

                case 2:
                    paintType = "Standard Paint";
                    pricePerSquareMeter = 12;
                    break;

                case 3:
                    paintType = "Premium Paint";
                    pricePerSquareMeter = 18;
                    break;

                default:
                    paintType = "Standard Paint";
                    pricePerSquareMeter = 12;
                    break;
            }

            double totalCost = totalWallArea * pricePerSquareMeter;

            Console.WriteLine("=========== Painting Report ===========");
            Console.WriteLine($"Room Name: {roomName}");
            Console.WriteLine($"Wall Count: {wallCount}");
            Console.WriteLine($"Total Wall Area: {totalWallArea} m²");
            Console.WriteLine($"Paint Type: {paintType}");
            Console.WriteLine($"Price Per Square Meter: {pricePerSquareMeter}");
            Console.WriteLine($"Total Painting Cost: {totalCost}");
        }
    }
}
