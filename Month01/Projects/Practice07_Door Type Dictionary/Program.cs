using System;
using System.Collections.Generic;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string,string> doorTypes=new Dictionary<string, string>();

        addingNewType(doorTypes, "D01", "Singel Flush Door");
        addingNewType(doorTypes, "D02", "Double Glass Door");
        addingNewType(doorTypes, "D03", "Fire Rated Door");
        addingNewType(doorTypes, "D02", "Another Door");

        Console.WriteLine();
        Console.WriteLine("Search Result:");
        SearchDoorType(doorTypes, "D03");


        Console.WriteLine();
        Console.WriteLine("All Door Types:");
        DisplayInfo(doorTypes);





    }
    static void addingNewType(Dictionary<string, string> doorTypes, string code, string name)
    {
        if (!doorTypes.ContainsKey(code))
        {
            doorTypes.Add(code, name);
            Console.WriteLine($"Added: {code} - {name}");
        }
        else
        {
            Console.WriteLine($"Duplicate code not allowed: {code}");
        }

    }
    static void SearchDoorType(Dictionary<string,string> doorTypes, string code)
    {
        if (doorTypes.ContainsKey(code))
        {
            Console.WriteLine($"Found: {code}-{doorTypes[code]}");
        }
        else
        {
            Console.WriteLine($"Door type not found for code: {code}");
        }
    }
    static void DisplayInfo(Dictionary<string,string> doortypes)
    {
        foreach(KeyValuePair<string,string> door in doortypes)
        {
            Console.WriteLine($"Door Type:{door.Key} | Door Name {door.Value}");
        }
    }
}