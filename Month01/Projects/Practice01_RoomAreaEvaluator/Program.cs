using System;
namespace RoomAreaEvaluator
{
    class Room
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Room Name:");
            string name=Console.ReadLine();

            Console.WriteLine("Enter The Room Length:");
            double length=double.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Room Width:");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Room Information");
            Console.WriteLine();
            Console.WriteLine($"Room Name: {name} | Room Length: {length} | Room Width: {width}");
            Console.WriteLine();
            Area(length,width);





        }
        static void Area(double length, double width)
        {
            double area= length* width;
            Console.WriteLine($"Area: {area}");
            Console.WriteLine();
            if (area<10)
            {
                Console.WriteLine("Small Room");
            }
            else if (25>=area && area>=10)
            {
                Console.WriteLine("Medium Room");
            }
            else
            {
                Console.WriteLine("Big Room");
            }
        }
    }
}