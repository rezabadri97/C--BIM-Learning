using System;
namespace RoomPaintingCostCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Room Name:");
            string name=Console.ReadLine();

            Console.WriteLine("Enter Walls Count:");
            int wallsCount=int.Parse(Console.ReadLine());

            double wallsArea = 0;

            for(int i=1; i<=wallsCount; i++)
            {
                Console.WriteLine($"Enter Wall Length Number {i}:");
                double wallLength=double.Parse(Console.ReadLine());

                Console.WriteLine($"Enter Wall Height Number {i}:");
                double wallHeight = double.Parse(Console.ReadLine());
                double area = wallLength * wallHeight;

                wallsArea += area;
            }
            Console.WriteLine("Enter Wall Paint Type: \n");
            Console.WriteLine("1. Economy Paint : 8 \n");
            Console.WriteLine("2. Standard Paint : 12\n");
            Console.WriteLine("3. Premium Paint : 18 \n");
            int paintType=int.Parse(Console.ReadLine());

            double price = 0;

            switch (paintType)
            {
                case 1:
                    price = 8;
                    break;

                case 2:
                    price = 12;
                    break;
                case 3:
                    price = 18;
                    break;
                default:
                    price = 12;
                    break;
            }
            double finalPrice = price * wallsArea;


            Console.WriteLine($"Wall Name: {name}");
            Console.WriteLine($"Wall Count: {wallsCount}");
            Console.WriteLine($"Walls Area: {wallsArea}");
            switch (paintType)
            {
                case 1:
                    Console.WriteLine($"Paint Type: Econmy Paint");
                    Console.WriteLine($"Paint Price :8$ for every 1sqam ");
                    break;

                case 2:
                    Console.WriteLine($"Paint Type: Standard Paint");
                    Console.WriteLine($"Paint Price :12$ for every 1sqam ");
                    break;
                case 3:
                    Console.WriteLine($"Paint Type: Premium Paint ");
                    Console.WriteLine($"Paint Price :18$ for every 1sqam ");
                    break;
                default:
                    Console.WriteLine($"Paint Type: Standard Paint");
                    Console.WriteLine($"Paint Price :12$ for every 1sqam ");
                    break;
            }

            Console.WriteLine($"Final Price: {finalPrice}");

        }




    }

}
