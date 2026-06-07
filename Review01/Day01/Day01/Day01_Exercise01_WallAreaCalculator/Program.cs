using System;
using System.Security.Cryptography.X509Certificates;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Wall Name");
        string wallName=Console.ReadLine();
        
        Console.WriteLine("Enter Wall Length");
        double wallLength =double.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter Wall Height");
        double wallHeight = double.Parse(Console.ReadLine());

        double area = wallHeight * wallLength;


        Console.WriteLine($"Wall Name: {wallName}");
        Console.WriteLine($"Wall Length: {wallLength}");
        Console.WriteLine($"Wall Height: {wallHeight}");
        Console.WriteLine($"Wall Area: {area}");




        if (area<10)
        {
            Console.WriteLine("Small Wall");
        }
        if(10<=area && area<30)
        {
            Console.WriteLine("Medium Wall");
        }
        if (area>30)
        {
            Console.WriteLine("Large Wall");
        }






    }
}