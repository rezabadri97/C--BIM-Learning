using System;

namespace BimDeveloperPractice.Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIM Wall Volume Calculator");
            Console.WriteLine("--------------------------");

            Console.Write("Enter wall name: ");
            string wallName = Console.ReadLine();

            double length = ReadPositiveDouble("Enter wall length in meters: ");
            double height = ReadPositiveDouble("Enter wall height in meters: ");
            double thickness = ReadPositiveDouble("Enter wall thickness in meters: ");

            double volume = CalculateWallVolume(length, height, thickness);

            Console.WriteLine();
            Console.WriteLine("Wall Quantity Report");
            Console.WriteLine("--------------------");
            Console.WriteLine("Wall Name: " + wallName);
            Console.WriteLine("Length: " + length + " m");
            Console.WriteLine("Height: " + height + " m");
            Console.WriteLine("Thickness: " + thickness + " m");
            Console.WriteLine("Volume: " + volume + " m3");

            Console.WriteLine();
            Console.WriteLine("Program finished.");
        }

        static double ReadPositiveDouble(string message)
        {
            double number = 0;
            bool isValid = false;

            while (!isValid)
            {
                Console.Write(message);
                string input = Console.ReadLine();

                bool parsed = double.TryParse(input, out number);

                if (parsed && number > 0)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                }
            }

            return number;
        }

        static double CalculateWallVolume(double length, double height, double thickness)
        {
            double volume = length * height * thickness;
            return volume;
        }
    }
}
