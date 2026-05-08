using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> levelRoomCounts = new Dictionary<string, int>();

        AddLevel(levelRoomCounts, "Level 1", 5);
        AddLevel(levelRoomCounts, "Level 2", 3);
        AddLevel(levelRoomCounts, "Level 3", 8);

        IncreaseRoomCount(levelRoomCounts, "Level 1");
        IncreaseRoomCount(levelRoomCounts, "Level 2");
        IncreaseRoomCount(levelRoomCounts, "Level 2");

        Console.WriteLine();
        SearchLevel(levelRoomCounts, "Level 2");

        Console.WriteLine();
        ShowAllLevels(levelRoomCounts);
    }

    static void AddLevel(Dictionary<string, int> data, string levelName, int roomCount)
    {
        if (!data.ContainsKey(levelName))
        {
            data.Add(levelName, roomCount);
            Console.WriteLine("Added level: " + levelName);
        }
        else
        {
            Console.WriteLine("Level already exists: " + levelName);
        }
    }

    static void IncreaseRoomCount(Dictionary<string, int> data, string levelName)
    {
        if (data.ContainsKey(levelName))
        {
            data[levelName] = data[levelName] + 1;
            Console.WriteLine("Updated room count for " + levelName + ": " + data[levelName]);
        }
        else
        {
            Console.WriteLine("Level not found: " + levelName);
        }
    }

    static void SearchLevel(Dictionary<string, int> data, string levelName)
    {
        if (data.ContainsKey(levelName))
        {
            Console.WriteLine(levelName + " has " + data[levelName] + " rooms.");
        }
        else
        {
            Console.WriteLine("Level not found.");
        }
    }

    static void ShowAllLevels(Dictionary<string, int> data)
    {
        Console.WriteLine("All Levels:");
        foreach (KeyValuePair<string, int> item in data)
        {
            Console.WriteLine(item.Key + " => " + item.Value + " rooms");
        }
    }
}
