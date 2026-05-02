using System;

class Program
{
    static void Main(string[] args)
    {
        string[] roomNames = { " lobby ", "conference room", "MEP room", " office 101 " };
        double[] roomAreas = { 45.5, 32.8, 18.2, 27.4 };

        DisplayRoomReport(roomNames, roomAreas);

        int bigRoomCount = 0;

        for (int i = 0; i < roomAreas.Length; i++)
        {
            if (roomAreas[i] > 30)
            {
                bigRoomCount++;
            }
        }

        int largestIndex = FindLargestRoomIndex(roomAreas);

        Console.WriteLine($"Areas Average: {CalculateAverageArea(roomAreas)}");
        Console.WriteLine($"Largest Room: {CleanRoomName(roomNames[largestIndex])} | Area: {roomAreas[largestIndex]}");
        Console.WriteLine($"Count Of Big Rooms: {bigRoomCount}");

        SmallestRoomReport(roomNames, roomAreas);
    }

    static string CleanRoomName(string name)
    {
        return name.Trim().ToUpper();
    }

    static double CalculateAverageArea(double[] areas)
    {
        double sum = 0;

        for (int i = 0; i < areas.Length; i++)
        {
            sum += areas[i];
        }

        double average = sum / areas.Length;
        return average;
    }

    static int FindLargestRoomIndex(double[] areas)
    {
        int maxIndex = 0;

        for (int i = 1; i < areas.Length; i++)
        {
            if (areas[i] > areas[maxIndex])
            {
                maxIndex = i;
            }
        }

        return maxIndex;
    }

    static void DisplayRoomReport(string[] names, double[] areas)
    {
        Console.WriteLine("ROOM REPORT");
        Console.WriteLine("-----------");

        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {CleanRoomName(names[i])} - {areas[i]} m2 {GetRoomLabel(names[i])}");
        }
    }

    static void SmallestRoomReport(string[] names, double[] areas)
    {
        double smallestRoomArea = areas[0];
        string smallestRoomName = names[0];

        for (int i = 1; i < areas.Length; i++)
        {
            if (areas[i] < smallestRoomArea)
            {
                smallestRoomArea = areas[i];
                smallestRoomName = names[i];
            }
        }

        Console.WriteLine($"Smallest Room: {CleanRoomName(smallestRoomName)} | Area: {smallestRoomArea}");
    }

    static string GetRoomLabel(string name)
    {
        string cleanName = CleanRoomName(name);

        if (cleanName.Contains("MEP"))
        {
            return "- Technical Room";
        }

        return "";
    }
}
