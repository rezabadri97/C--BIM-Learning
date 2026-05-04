using System;
using System.Collections.Generic;

internal class Program
{
    static void Main(string[] args)
    {
        List<string> roomNames = new List<string>();
        roomNames.Add("Lobby");
        roomNames.Add("Office 101");
        roomNames.Add("MEP Room");
        roomNames.Add("Storage");
        roomNames.Add("Conference Room");
        Console.WriteLine("******************************");
        Console.WriteLine();
        Console.WriteLine("Original List Names:");
        Console.WriteLine();
        Console.WriteLine(roomNames);
        Console.WriteLine();
        Console.WriteLine("******************************");
        Console.WriteLine();
        Console.WriteLine("Clean List Names:");
        Console.WriteLine();
        cleanNames(roomNames);
        Console.WriteLine();
        Console.WriteLine("******************************");
        Console.WriteLine();
        bool removed = roomNames.Remove("Storage");
        
        string foundName = roomNames.Find(room => room.ToUpper().Contains("MEP"));
        Console.WriteLine("Updeted List Names:");
        cleanNames(roomNames);
        Console.WriteLine();
        Console.WriteLine($"Any Room Removed? {removed}");
        Console.WriteLine();
        if (foundName !=null)
        {
            Console.WriteLine($"Found MEP Room: {foundName}");
        }
        else
        {
            Console.WriteLine("No MEP Room Was Wound.");
        }


    }
    static void cleanNames(List<string> roomNames)
    {
        int count = 0;
        foreach(string room in roomNames)
        
        {
            count++;
            Console.WriteLine($"{count}-{room.Trim().ToUpper()}");
            Console.WriteLine();
        }
        Console.WriteLine($"Room Counts: {count}");
    }
}