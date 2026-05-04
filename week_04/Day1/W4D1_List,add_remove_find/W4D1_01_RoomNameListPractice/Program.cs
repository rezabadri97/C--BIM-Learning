using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        List<double> wallLength = new List<double>();

        wallLength.Add(4.5);
        wallLength.Add(6.2);
        wallLength.Add(3.8);
        wallLength.Add(5.1);
        wallLength.Add(2.9);
        Console.WriteLine("********************************************");
        Console.WriteLine("Original Wall Lengths:");
        Console.WriteLine();
        DisplayLength(wallLength);
        CalculateTotalLength(wallLength);
        WallCount(wallLength);
        
        Console.WriteLine("********************************************");
       
        bool removed=wallLength.Remove(2.9);
        Console.WriteLine("Updated Wall Lengths:");
        Console.WriteLine();
        Console.WriteLine($"Was 2.9 removed? {removed}");
        DisplayLength(wallLength);
        CalculateTotalLength(wallLength);
        
        Console.WriteLine("********************************************");
        double foundLength = wallLength.Find(length => length > 5);
        Console.WriteLine();
        if (foundLength != 0)
        {
            Console.WriteLine($"First wall length greater than 5: {foundLength}");
        }
        else
        {
            Console.WriteLine("No wall length greater than 5 was found.");
        }
    }
    static void CalculateTotalLength(List<double> wallLength)
    {
        double totalLength = 0;
        for (int i=0; i<wallLength.Count; i++)
        {
            totalLength += wallLength[i];
        }
        Console.WriteLine($"Total Length: {totalLength}");

    }
    static void DisplayLength(List<double> wallLength)
    {
        for(int i=0;i<wallLength.Count; i++)
        {
            Console.WriteLine($"Wall-{i + 1}: {wallLength[i]} ");
        }
    }
    static void WallCount(List<double> wallLength)
    {
        int wallCount = 0;
        for (int i = 0; i < wallLength.Count; i++)
        { 
            wallCount++; 
        }
        Console.WriteLine($"Wall Count: {wallCount}");
    }
}