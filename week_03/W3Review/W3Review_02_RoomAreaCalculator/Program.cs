using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Room Length: ");
        double length = double.Parse(Console.ReadLine());


        Console.WriteLine("Enter Room Width:");
        double width = double.Parse(Console.ReadLine());

        if (length <= 0 || width <= 0)
        {
            Console.WriteLine("Error: Length and width must be greater than zero.");
        }
        else
        {
            double area = CalculateRoomArea(length, width);

            double perimeter = CalculateRoomPerimeter(length, width);

            Console.WriteLine($"Room Area: {area} ");
            Console.WriteLine($"Room Primeter: {perimeter} ");
        }
    }
    static double CalculateRoomArea(double length, double width)
        {
            return length * width;
        }
    static double CalculateRoomPerimeter(double length, double width)
        {
            return (length + width) * 2;
        }
}
